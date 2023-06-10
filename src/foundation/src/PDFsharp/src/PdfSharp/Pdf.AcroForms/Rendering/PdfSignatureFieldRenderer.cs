using PdfSharp.Drawing;
using PdfSharp.Pdf.Annotations;

namespace PdfSharp.Pdf.AcroForms.Rendering
{
    /// <summary>
    /// Renders a <see cref="PdfSignatureField"/>
    /// </summary>
    public class PdfSignatureFieldRenderer
    {
        /// <summary>
        /// Renders the <see cref="PdfSignatureField"/>
        /// </summary>
        /// <param name="field">The field being rendered</param>
        /// <param name="widget">The <see cref="PdfWidgetAnnotation"/> of the field that is being rendered</param>
        /// <param name="gfx">The <see cref="XGraphics"/> used to perform drawing operations</param>
        /// <param name="rect">The <see cref="XRect"/> spcifying the position and dimensions of the field</param>
        public virtual void Render(PdfSignatureField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
        {

        }
    }
}
