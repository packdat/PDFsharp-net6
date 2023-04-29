// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Drawing;
using PdfSharp.Pdf.Annotations;
using PdfSharp.Pdf.Internal;

namespace PdfSharp.Pdf.AcroForms
{
    /// <summary>
    /// Represents the combo box field.
    /// </summary>
    public sealed class PdfComboBoxField : PdfChoiceField
    {
        /// <summary>
        /// Initializes a new instance of PdfComboBoxField.
        /// </summary>
        internal PdfComboBoxField(PdfDocument document)
            : base(document)
        {
            SetFlags |= PdfAcroFieldFlags.Combo;
        }

        internal PdfComboBoxField(PdfDictionary dict)
            : base(dict)
        { }

        /// <summary>
        /// Gets or sets the index of the selected item
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                string value = Elements.GetString(PdfAcroField.Keys.V);
                // try export value first
                var index = IndexInOptArray(value, true);
                if (index < 0)
                    index = IndexInOptArray(value, false);
                return index;
            }
            set
            {
                string key = ValueInOptArray(value, true);
                Elements.SetString(PdfAcroField.Keys.V, key);
            }
        }

        void RenderAppearance()
        {
            if (Font is null)
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
                var xRect = new XRect(0, 0, Math.Max(DeterminedFontSize, Math.Max(1.0, rect.Width)), Math.Max(DeterminedFontSize, Math.Max(1.0, rect.Height)));
                var form = new XForm(_document, xRect);
                using (var gfx = XGraphics.FromForm(form))
                {
                    if (widget.BackColor != XColor.Empty)
                        gfx.DrawRectangle(new XSolidBrush(widget.BackColor), xRect);
                    // Draw Border
                    if (!widget.BorderColor.IsEmpty)
                        gfx.DrawRectangle(new XPen(widget.BorderColor), xRect);

                    var index = SelectedIndex;
                    if (index > 0)
                    {
                        var text = ValueInOptArray(index, false);
                        if (!String.IsNullOrEmpty(text))
                        {
                            var format = TextAlign == TextAlignment.Left ? XStringFormats.CenterLeft : TextAlign == TextAlignment.Center ? XStringFormats.Center : XStringFormats.CenterRight;
                            gfx.DrawString(text, Font, new XSolidBrush(ForeColor), xRect, format);
                        }
                    }
                }
                form.DrawingFinished();

                SetXFormFont(form);

                var ap = new PdfDictionary(this._document);
                widget.Elements[PdfAnnotation.Keys.AP] = ap;
                widget.Elements.SetName(PdfAnnotation.Keys.AS, "/N");   // set appearance state
                // Set XRef to normal state
                ap.Elements["/N"] = form.PdfForm.Reference;

                var xobj = form.PdfForm;
                var s = xobj.Stream.ToString();
                s = "/Tx BMC\n" + s + "\nEMC";
                xobj.Stream.Value = new RawEncoding().GetBytes(s);
            }
        }

        internal override void Flatten()
        {
            base.Flatten();

            if (Font is null)
                return;

            var index = SelectedIndex;
            if (index >= 0)
            {
                var text = ValueInOptArray(index, false);
                if (text.Length > 0)
                {
                    for (var i = 0; i < Annotations.Elements.Count; i++)
                    {
                        var widget = Annotations.Elements[i];
                        if (widget.Page != null)
                        {
                            var rect = widget.Rectangle;
                            if (!rect.IsEmpty)
                            {
                                var format = TextAlign == TextAlignment.Left ? XStringFormats.CenterLeft : TextAlign == TextAlignment.Center ? XStringFormats.Center : XStringFormats.CenterRight;
                                var xRect = new XRect(rect.X1, widget.Page.Height.Point - rect.Y2, rect.Width, rect.Height);
                                using (var gfx = XGraphics.FromPdfPage(widget.Page))
                                {
                                    gfx.Save();
                                    gfx.IntersectClip(xRect);
                                    // Note: Page origin [0,0] is bottom left !
                                    gfx.DrawString(text, Font, new XSolidBrush(ForeColor), xRect, format);
                                    gfx.Restore();
                                }
                            }
                        }
                    }
                }
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
            // Combo boxes have no additional entries.

            internal static DictionaryMeta Meta => Keys._meta ??= CreateMeta(typeof(Keys));

            static DictionaryMeta? _meta;
        }

        /// <summary>
        /// Gets the KeysMeta of this dictionary type.
        /// </summary>
        internal override DictionaryMeta Meta => Keys.Meta;
    }
}
