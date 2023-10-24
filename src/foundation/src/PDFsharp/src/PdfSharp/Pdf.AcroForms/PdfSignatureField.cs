// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Drawing;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.Annotations;

namespace PdfSharp.Pdf.AcroForms
{
    /// <summary>
    /// Represents the signature field.
    /// </summary>
    public sealed class PdfSignatureField : PdfAcroField
    {
        /// <summary>
        /// Initializes a new instance of PdfSignatureField.
        /// </summary>
        internal PdfSignatureField(PdfDocument document)
            : base(document)
        {
            Elements.SetName(Keys.FT, "Sig");
        }

        internal PdfSignatureField(PdfDictionary dict)
            : base(dict)
        { }

        /// <summary>
        /// Renders the appearance of this field
        /// </summary>
        protected override void RenderAppearance()
        {
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
                    Owner.AcroForm?.FieldRenderer.SignatureFieldRenderer.Render(this, widget, gfx, xRect);
                }
                form.DrawingFinished();

                // Get existing or create new appearance dictionary.
                if (widget.Elements[PdfAnnotation.Keys.AP] is not PdfDictionary ap)
                {
                    ap = new PdfDictionary(_document);
                    widget.Elements[PdfAnnotation.Keys.AP] = ap;
                }

                ap.Elements["/N"] = form.PdfForm.Reference;
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
            /// (Optional; shall be an indirect reference; PDF 1.5) A signature field lock dictionary
            /// that specifies a set of form fields that shall be locked when this signature field is signed.
            /// </summary>
            [KeyInfo(KeyType.Dictionary | KeyType.Optional)]
            public const string Lock = "/Lock";

            /// <summary>
            /// (Optional; shall be an indirect reference; PDF 1.5) A seed value dictionary (see Table 234)
            /// containing information that constrains the properties of a signature that is applied to this field.
            /// </summary>
            [KeyInfo(KeyType.Dictionary | KeyType.Optional)]
            public const string SV = "/SV";

            //
            // NOTE: The following entries are not part of a Signature field.
            // Rather, these are the key of a signature-dictionary (see PdfReference 1.7, Chapter 12.8)
            //

            /// <summary>
            /// (Optional) The type of PDF object that this dictionary describes; if present,
            /// must be Sig for a signature dictionary.
            /// </summary>
            [KeyInfo(KeyType.Name | KeyType.Optional)]
            public const string Type = "/Type";

            /// <summary>
            /// (Required; inheritable) The name of the signature handler to be used for
            /// authenticating the field�s contents, such as Adobe.PPKLite, Entrust.PPKEF,
            /// CICI.SignIt, or VeriSign.PPKVS.
            /// </summary>
            [KeyInfo(KeyType.Name | KeyType.Required)]
            public const string Filter = "/Filter";

            /// <summary>
            /// (Optional) The name of a specific submethod of the specified handler.
            /// </summary>
            [KeyInfo(KeyType.Name | KeyType.Optional)]
            public const string SubFilter = "/SubFilter";

            /// <summary>
            /// (Required) An array of pairs of integers (starting byte offset, length in bytes)
            /// describing the exact byte range for the digest calculation. Multiple discontinuous
            /// byte ranges may be used to describe a digest that does not include the
            /// signature token itself.
            /// </summary>
            [KeyInfo(KeyType.Array | KeyType.Required)]
            public const string ByteRange = "/ByteRange";

            /// <summary>
            /// (Required) The encrypted signature token.
            /// </summary>
            [KeyInfo(KeyType.String | KeyType.Required)]
            public const string Contents = "/Contents";

            /// <summary>
            /// (Optional) The name of the person or authority signing the document.
            /// </summary>
            [KeyInfo(KeyType.TextString | KeyType.Optional)]
            public const string Name = "/Name";

            /// <summary>
            /// (Optional) The time of signing. Depending on the signature handler, this
            /// may be a normal unverified computer time or a time generated in a verifiable
            /// way from a secure time server.
            /// </summary>
            [KeyInfo(KeyType.Date | KeyType.Optional)]
            public const string M = "/M";

            /// <summary>
            /// (Optional) The CPU host name or physical location of the signing.
            /// </summary>
            [KeyInfo(KeyType.TextString | KeyType.Optional)]
            public const string Location = "/Location";

            /// <summary>
            /// (Optional) The reason for the signing, such as (I agree�).
            /// </summary>
            [KeyInfo(KeyType.TextString | KeyType.Optional)]
            public const string Reason = "/Reason";

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
