// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Drawing;
using PdfSharp.Pdf.Annotations;
using PdfSharp.Pdf.Internal;

namespace PdfSharp.Pdf.AcroForms
{
    /// <summary>
    /// Represents the list box field.
    /// </summary>
    public sealed class PdfListBoxField : PdfChoiceField
    {
        /// <summary>
        /// Initializes a new instance of PdfListBoxField.
        /// </summary>
        internal PdfListBoxField(PdfDocument document)
            : base(document)
        { }

        internal PdfListBoxField(PdfDictionary dict)
            : base(dict)
        { }

        /// <summary>
        /// Gets or sets the background color for selected items of the field.
        /// </summary>
        public XColor HighlightColor
        {
            get { return this.highlightColor; }
            set { this.highlightColor = value; }
        }
        XColor highlightColor = XColors.DarkBlue;

        /// <summary>
        /// Gets or sets the text-color for selected items of the field.
        /// </summary>
        public XColor HighlightTextColor
        {
            get { return this.highlightTextColor; }
            set { this.highlightTextColor = value; }
        }
        XColor highlightTextColor = XColors.White;

        /// <summary>
        /// Gets or sets the value for this ListBox<br></br>
        /// Note: As a <see cref="PdfListBoxField"/> may have multiple values selected, it is recommended to use <see cref="SelectedIndices"/> instead
        /// </summary>
        public override PdfItem? Value
        {
            get
            {
                if (SelectedIndices.Any())
                {
                    var val = ValueInOptArray(SelectedIndices.ElementAt(0), true);
                    if (String.IsNullOrEmpty(val))
                        val = ValueInOptArray(SelectedIndices.ElementAt(0), false);
                    if (!String.IsNullOrEmpty(val))
                        return new PdfString(val);
                }
                return null;
            }
            set
            {
                base.Value = value;
                if (value == null)
                    SelectedIndices = Array.Empty<int>();
                else
                {
                    var indices = new List<int>();
                    var index = IndexInOptArray(value.ToString()!, true);
                    if (index >= 0)
                        indices.Add(index);
                    SelectedIndices = indices.ToArray();
                }
            }
        }

        /// <summary>
        /// Gets or sets the Indices of the selected items of this Field
        /// </summary>
        public IEnumerable<int> SelectedIndices
        {
            get
            {
                var result = new List<int>();
                var ary = Elements.GetArray(PdfAcroField.Keys.V);       // /V takes precedence over /I
                if (ary != null)
                {
                    for (var i = 0; i < ary.Elements.Count; i++)
                    {
                        int idx;
                        var val = ary.Elements.GetString(i);
                        if (val != null && (idx = IndexInOptArray(val, true)) >= 0)
                            result.Add(idx);
                    }
                }
                if (result.Count > 0)
                    return result;

                ary = Elements.GetArray(PdfChoiceField.Keys.I);
                if (ary != null)
                {
                    foreach (var item in ary.Elements)
                    {
                        if (item is PdfInteger pdfInt)
                            result.Add(pdfInt.Value);
                    }
                }
                return result;
            }
            set
            {
                var indices = new PdfArray(_document);
                var values = new PdfArray(_document);
                foreach (var index in value)
                {
                    indices.Elements.Add(new PdfInteger(index));
                    values.Elements.Add(new PdfString(ValueInOptArray(index, true)));
                }
                if (indices.Elements.Count > 0)
                {
                    Elements.SetObject(PdfChoiceField.Keys.I, indices);
                    Elements.SetObject(PdfAcroField.Keys.V, values);
                }
                else
                {
                    Elements.Remove(PdfChoiceField.Keys.I);
                    Elements.Remove(PdfAcroField.Keys.V);
                }
            }
        }

        /// <summary>
        /// Gets or sets the index of the first visible item in the ListBox
        /// </summary>
        public int TopIndex
        {
            get { return Elements.GetInteger(PdfChoiceField.Keys.TI); }
            set
            {
                if (value < 0)
                    throw new ArgumentException("TopIndex must not be less than zero");
                Elements.SetInteger(PdfChoiceField.Keys.TI, value);
            }
        }

        protected override void RenderAppearance()
        {
            if (Font is null)
                return;

            for (var idx = 0; idx < Annotations.Elements.Count; idx++)
            {
                var widget = Annotations.Elements[idx];
                if (widget == null)
                    continue;

                var rect = widget.Rectangle;
                if (rect.IsEmpty)
                    continue;

                // ensure a minimum size of 1x1, otherwise an exception is thrown
                var xRect = new XRect(0, 0, Math.Max(DeterminedFontSize, Math.Max(1.0, rect.Width)), Math.Max(DeterminedFontSize, Math.Max(1.0, rect.Height)));
                var form = new XForm(_document, xRect);
                using (var gfx = XGraphics.FromForm(form))
                {
                    gfx.IntersectClip(xRect);
                    Owner.AcroForm?.FieldRenderer.ListBoxFieldRenderer.Render(this, widget, gfx, xRect);
                }
                form.DrawingFinished();
                SetXFormFont(form);

                var ap = new PdfDictionary(Owner);
                widget.Elements[PdfAnnotation.Keys.AP] = ap;
                ap.Elements["/N"] = form.PdfForm.Reference;

                var xobj = form.PdfForm;
                var s = xobj.Stream.ToString();
                s = "/Tx BMC\n" + s + "\nEMC";
                xobj.Stream.Value = new RawEncoding().GetBytes(s);
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
            // List boxes have no additional entries.

            internal static DictionaryMeta Meta => _meta ??= CreateMeta(typeof(Keys));

            static DictionaryMeta? _meta;
        }

        /// <summary>
        /// Gets the KeysMeta of this dictionary type.
        /// </summary>
        internal override DictionaryMeta Meta => Keys.Meta;
    }
}
