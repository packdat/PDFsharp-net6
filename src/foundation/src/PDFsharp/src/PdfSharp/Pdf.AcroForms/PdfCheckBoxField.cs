// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Drawing;
using PdfSharp.Pdf.Annotations;

namespace PdfSharp.Pdf.AcroForms
{
    /// <summary>
    /// Represents the check box field.
    /// </summary>
    public sealed class PdfCheckBoxField : PdfButtonField
    {
        /// <summary>
        /// Initializes a new instance of PdfCheckBoxField.
        /// </summary>
        internal PdfCheckBoxField(PdfDocument document)
            : base(document)
        {
            _document = document;
        }

        internal PdfCheckBoxField(PdfDictionary dict)
            : base(dict)
        { }

        /// <summary>
        /// Gets or sets the value of this field. This should be either <b>Off</b> or 
        /// the result of <see cref="PdfButtonField.GetNonOffValue()"/> (typically <b>Yes</b>)
        /// </summary>
        public new string Value
        {
            get { return (base.Value?.ToString() ?? "Off").TrimStart('/'); }
            set
            {
                if (value != null && value.Equals(GetNonOffValueInternal().TrimStart('/'), StringComparison.OrdinalIgnoreCase))
                {
                    Elements.SetName(PdfAcroField.Keys.V, value);
                }
                else if (value != "Off" && value != GetNonOffValueInternal())
                    throw new ArgumentException($"'{value}' is not a valid value for field '{FullyQualifiedName}'. Valid values are either '/Off' or '{GetNonOffValueInternal()}'");
                else
                    Elements.SetName(PdfAcroField.Keys.V, "/Off");
            }
        }

        /// <summary>
        /// Indicates whether the field is checked.
        /// </summary>
        public bool Checked
        {
            get
            {
                var value = Elements.GetString(PdfAcroField.Keys.V);
                var widget = Annotations.Elements.Count > 0 ? Annotations.Elements[0] : null;
                if (widget != null)
                {
                    if (string.IsNullOrEmpty(value))
                        value = widget.Elements.GetString(PdfAnnotation.Keys.AS);
                    var appearances = widget.Elements.GetDictionary(PdfAnnotation.Keys.AP);
                    if (appearances != null)
                    {
                        var normalState = appearances.Elements.GetDictionary("/N");
                        if (normalState != null)
                            return value.Length != 0 && value != "/Off" && normalState.Elements.ContainsKey(value);
                    }
                }
                return value.Length != 0 && value != "/Off";
            }
            set
            {
                var name = value ? GetNonOffValueInternal() : "/Off";
                Elements.SetName(PdfAcroField.Keys.V, name);
            }
        }

        /// <summary>
        /// Renders the appearance of this field
        /// </summary>
        protected override void RenderAppearance()
        {
            for (var i = 0; i < Annotations.Elements.Count; i++)
            {
                var widget = Annotations.Elements[i];
                var rect = widget.Rectangle;
                if (rect.IsEmpty)
                    continue;
                // existing/imported field ?
                if (widget.Elements.ContainsKey(PdfAnnotation.Keys.AP))
                {
                    widget.Elements.SetName(PdfAnnotation.Keys.AS, Checked ? GetNonOffValueInternal() : "/Off");
                }
                else    // newly created field
                {
                    var xRect = new XRect(0, 0, Math.Max(1, rect.Width), Math.Max(1, rect.Height));
                    // checked state
                    var formChecked = new XForm(_document, xRect);
                    using (var gfx = XGraphics.FromForm(formChecked))
                    {
                        gfx.IntersectClip(xRect);
                        Owner.AcroForm?.FieldRenderer.CheckBoxFieldRenderer.RenderCheckedState(this, widget, gfx, xRect);
                    }
                    formChecked.DrawingFinished();
                    SetXFormFont(formChecked);

                    // unchecked state
                    var formUnchecked = new XForm(_document, rect.ToXRect());
                    using (var gfx = XGraphics.FromForm(formUnchecked))
                    {
                        gfx.IntersectClip(xRect);
                        Owner.AcroForm?.FieldRenderer.CheckBoxFieldRenderer.RenderUncheckedState(this, widget, gfx, xRect);
                    }
                    formUnchecked.DrawingFinished();
                    SetXFormFont(formUnchecked);

                    var ap = new PdfDictionary(_document);
                    var nDict = new PdfDictionary(_document);
                    ap.Elements.SetValue("/N", nDict);
                    nDict.Elements["/Yes"] = formChecked.PdfForm.Reference;     // according to the spec (12.7.4.2.3)
                    nDict.Elements["/Off"] = formUnchecked.PdfForm.Reference;
                    widget.Elements[PdfAnnotation.Keys.AP] = ap;
                    widget.Elements.SetName(PdfAnnotation.Keys.AS, Checked ? "/Yes" : "/Off");   // set appearance state
                }
            }
        }

        internal override void PrepareForSave()
        {
            base.PrepareForSave();
            RenderAppearance();
        }

        /// <summary>
        /// Gets or sets the name of the dictionary that represents the Checked state.
        /// </summary>
        /// The default value is "/Yes".
        public string CheckedName
        {
            get => _checkedName;
            set => _checkedName = value;
        }

        string _checkedName = "/Yes";

        /// <summary>
        /// Gets or sets the name of the dictionary that represents the Unchecked state.
        /// The default value is "/Off".
        /// </summary>
        public string UncheckedName
        {
            get => _uncheckedName;
            set => _uncheckedName = value;
        }

        string _uncheckedName = "/Off";

        /// <summary>
        /// Predefined keys of this dictionary. 
        /// The description comes from PDF 1.4 Reference.
        /// </summary>
        public new class Keys : PdfButtonField.Keys
        {
            /// <summary>
            /// (Optional; inheritable; PDF 1.4) A text string to be used in place of the V entry for the
            /// value of the field.
            /// </summary>
            [KeyInfo(KeyType.TextString | KeyType.Optional)]
            public const string Opt = "/Opt";

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
