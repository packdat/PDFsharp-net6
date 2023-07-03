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
                if (value >= 0)
                {
                    if (value >= Options.Count)
                        throw new ArgumentOutOfRangeException(nameof(value), value, 
                            $"SelectedIndex for field '{FullyQualifiedName}' must be smaller than {Options.Count}");

                    string key = ValueInOptArray(value, true);
                    Elements.SetString(PdfAcroField.Keys.V, key);
                }
                else
                    Elements.SetString(PdfAcroField.Keys.V, string.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the value of this field. This should be an item from the <see cref="PdfChoiceField.Options"/> list.<br></br>
        /// </summary>
        public new string Value
        {
            get { return (base.Value?.ToString() ?? string.Empty).TrimStart('(').TrimEnd(')'); }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    var index = IndexInOptArray(value, true);
                    if (index < 0)
                        throw new ArgumentException($"'{value}' is not a valid value for field '{FullyQualifiedName}'. Valid values are: [{string.Join(',', Options)}]");
                    
                    Elements.SetString(PdfAcroField.Keys.V, index >= 0 ? value : string.Empty);
                    SelectedIndex = index;
                }
                else
                    SelectedIndex = -1;
            }
        }


        protected override void RenderAppearance()
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
                    gfx.IntersectClip(xRect);
                    Owner.AcroForm?.FieldRenderer.ComboBoxFieldRenderer.Render(this, widget, gfx, xRect);
                }
                form.DrawingFinished();
                SetXFormFont(form);

                var ap = new PdfDictionary(Owner);
                widget.Elements[PdfAnnotation.Keys.AP] = ap;
                // Set XRef to normal state
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
