// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.Annotations;
using PdfSharp.Pdf.Internal;

namespace PdfSharp.Pdf.AcroForms
{
    /// <summary>
    /// Represents the text field.
    /// </summary>
    public sealed class PdfTextField : PdfAcroField
    {
        /// <summary>
        /// Initializes a new instance of PdfTextField.
        /// </summary>
        internal PdfTextField(PdfDocument document)
            : base(document)
        {
            Elements.SetName(Keys.FT, "Tx");
        }

        internal PdfTextField(PdfDictionary dict)
            : base(dict)
        { }

        /// <summary>
        /// Same as <see cref="Text"/> (which should be used instead)
        /// </summary>
        public new string Value
        {
            get => Text;
            set => Text = value;
        }

        /// <summary>
        /// Gets or sets the text value of the text field.
        /// </summary>
        public string Text
        {
            get { return Elements.GetString(PdfAcroField.Keys.V); }
            set
            {
                if (ReadOnly)
                    throw new InvalidOperationException("The field is read only.");
                // TODO: check MaxLength ? (risky -> potential data-loss)

                var isUnicodeText = (value ?? string.Empty).Any(c => c > 255);
                if (isUnicodeText && BaseContentFontName is not null && (Font == null || Font.PdfOptions.FontEncoding != PdfFontEncoding.Unicode))
                {
                    // HACK to support Unicode chars in Form-Fields
                    if (IsStandardFont(BaseContentFontName, out var fontStyle))
                        Font = new XFont(BaseContentFontName.TrimStart('/'), Math.Max(1.0, FontSizeForRendering), fontStyle, new XPdfFontOptions(PdfFontEncoding.Unicode));
                    else
                        Font = new XFont(BaseContentFontName.TrimStart('/'), Math.Max(1.0, FontSizeForRendering), XFontStyleEx.Regular, new XPdfFontOptions(PdfFontEncoding.Unicode));
                }
                Elements.SetString(PdfAcroField.Keys.V, value ?? string.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the maximum length of the field.
        /// </summary>
        /// <value>The length of the max.</value>
        public int MaxLength
        {
            get { return Elements.GetInteger(Keys.MaxLen); }
            set { Elements.SetInteger(Keys.MaxLen, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the field has multiple lines.
        /// </summary>
        public bool MultiLine
        {
            get { return (Flags & PdfAcroFieldFlags.Multiline) != 0; }
            set
            {
                if (value)
                    SetFlags |= PdfAcroFieldFlags.Multiline;
                else
                    SetFlags &= ~PdfAcroFieldFlags.Multiline;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this field is used for passwords.
        /// </summary>
        public bool Password
        {
            get { return (Flags & PdfAcroFieldFlags.Password) != 0; }
            set
            {
                if (value)
                    SetFlags |= PdfAcroFieldFlags.Password;
                else
                    SetFlags &= ~PdfAcroFieldFlags.Password;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this field is a combined field.
        /// A combined field is a text field made up of multiple "combs" of equal width. The number of combs is determined by <see cref="MaxLength"/>.
        /// </summary>
        public bool Combined
        {
            get { return (Flags & PdfAcroFieldFlags.CombTextField) != 0; }
            set
            {
                if (value)
                    SetFlags |= PdfAcroFieldFlags.CombTextField;
                else
                    SetFlags &= ~PdfAcroFieldFlags.CombTextField;
            }
        }

        /// <summary>
        /// Creates the normal appearance form X object for the annotation that represents
        /// this acro form text field.
        /// </summary>
        protected override void RenderAppearance()
        {
            if (Font == null)
                return;

            for (var i = 0; i < Annotations.Elements.Count; i++)
            {
                var widget = Annotations.Elements[i];
                if (widget == null)
                    continue;

                var rect = widget.Rectangle;
                if (rect.IsEmpty)
                    continue;

                // ensure a minimum size of 1x1, otherwise an exception is thrown
                var xRect = new XRect(0, 0, Math.Max(FontSizeForRendering, Math.Max(1.0, rect.Width)), Math.Max(FontSizeForRendering, Math.Max(1.0, rect.Height)));
                var form = (widget.Rotation == 90 || widget.Rotation == 270) && (widget.Flags & PdfAnnotationFlags.NoRotate) == 0
                    ? new XForm(_document, rect.Height, rect.Width)
                    : new XForm(_document, xRect);
                
                if (widget.Rotation != 0 && (widget.Flags & PdfAnnotationFlags.NoRotate) == 0)
                {
                    // I could not get this to work using gfx.Rotate/Translate Methods...
                    const double deg2Rad = 0.01745329251994329576923690768489;  // PI/180
                    var sr = Math.Sin(widget.Rotation * deg2Rad);
                    var cr = Math.Cos(widget.Rotation * deg2Rad);
                    // see PdfReference 1.7, Chapter 8.3.3 (Common Transformations)
                    // TODO: Is this always correct ? I had only the chance to test this with a 90 degree rotation...
                    form.PdfForm.Elements.SetMatrix(PdfFormXObject.Keys.Matrix, new XMatrix(cr, sr, -sr, cr, xRect.Width, 0));
                    if (widget.Rotation == 90 || widget.Rotation == 270)
                        xRect = new XRect(0, 0, rect.Height, rect.Width);
                }

                using (var gfx = XGraphics.FromForm(form))
                {
                    gfx.IntersectClip(xRect);
                    Owner.AcroForm?.FieldRenderer.TextFieldRenderer.Render(this, widget, gfx, xRect);
                }
                form.DrawingFinished();
                SetXFormFont(form);

                // Get existing or create new appearance dictionary.
                if (widget.Elements[PdfAnnotation.Keys.AP] is not PdfDictionary ap)
                {
                    ap = new PdfDictionary(_document);
                    widget.Elements[PdfAnnotation.Keys.AP] = ap;
                }

                ap.Elements["/N"] = form.PdfForm.Reference;

                var xobj = form.PdfForm;
                var s = xobj.Stream.ToString();
                // Thank you Adobe: Without putting the content in 'EMC brackets'
                // the text is not rendered by PDF Reader 9 or higher.
                s = "/Tx BMC\n" + s + "\nEMC";
                xobj.Stream.Value = new RawEncoding().GetBytes(s);
            }
            // create DefaultAppearance for newly created fields (required according to the spec)
            if (!Elements.ContainsKey(Keys.DA) && _document.AcroForm != null)
            {
                var fontName = Font.FromDocument ? Font.DocumentFontName : null;
                if (fontName == null)
                {
                    var pdfFont = _document.FontTable.GetFont(Font);
                    var formResources = _document.AcroForm.GetOrCreateResources();
                    fontName = formResources.AddFont(pdfFont);
                }
                Elements.Add(Keys.DA, new PdfString(string.Format(
                    CultureInfo.InvariantCulture, "{0} {1} Tf {2:0.###} {3:0.###} {4:0.###} rg",
                    fontName, Font.Size, ForeColor.R / 255.0, ForeColor.G / 255.0, ForeColor.B / 255.0)));
            }
        }

        internal override void PrepareForSave()
        {
            base.PrepareForSave();
            RenderAppearance();
        }

        /// <summary>
        /// Predefined keys of this dictionary. 
        /// The description comes from PDF 1.4 Reference.
        /// </summary>
        public new class Keys : PdfAcroField.Keys
        {
            /// <summary>
            /// (Optional; PDF 1.5) A default style string, as described in 12.7.3.4, “Rich Text Strings.”
            /// </summary>
            [KeyInfo(KeyType.String | KeyType.Optional)]
            public const string DS = "/DS";

            /// <summary>
            /// (Optional; PDF 1.5) A rich text string, as described in 12.7.3.4, “Rich Text Strings.”
            /// </summary>
            [KeyInfo(KeyType.String | KeyType.Optional)]
            public const string RV = "/RV";

            /// <summary>
            /// (Optional; inheritable) The maximum length of the field’s text, in characters.
            /// </summary>
            [KeyInfo(KeyType.Integer | KeyType.Optional)]
            public const string MaxLen = "/MaxLen";

            /// <summary>
            /// Gets the KeysMeta for these keys.
            /// </summary>
            internal static DictionaryMeta Meta => _meta ??= CreateMeta(typeof(Keys));

            static DictionaryMeta? _meta;
        }

        /// <summary>
        /// Gets the KeysMeta of this dictionary type.
        /// </summary>
        internal override DictionaryMeta Meta => Keys.Meta;
    }
}
