// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Pdf.Annotations;

namespace PdfSharp.Pdf.AcroForms
{
    /// <summary>
    /// Represents the base class for all button fields.
    /// </summary>
    public abstract class PdfButtonField : PdfAcroField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfButtonField"/> class.
        /// </summary>
        protected PdfButtonField(PdfDocument document)
            : base(document)
        {
            Elements.SetName(Keys.FT, "Btn");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfButtonField"/> class.
        /// </summary>
        protected PdfButtonField(PdfDictionary dict)
            : base(dict)
        { }

        /// <summary>
        /// Gets the name which represents the opposite of /Off.
        /// </summary>
        protected string? GetNonOffValue()
        {
            // Try to get the information from the appearance dictionary.
            // Just return the first key that is not /Off.
            // I'm not sure what is the right solution to get this value.
            if (Annotations.Elements.Count > 0)
            {
                var widget = Annotations.Elements[0];
                if (widget != null)
                {
                    var ap = widget.Elements.GetDictionary(PdfAnnotation.Keys.AP);
                    if (ap != null)
                    {
                        var n = ap.Elements.GetDictionary("/N");
                        if (n != null)
                        {
                            foreach (string name in n.Elements.Keys)
                                if (name != "/Off")
                                    return name;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the name which represents the opposite of /Off for the specified widget.
        /// </summary>
        /// <param name="widget"></param>
        /// <returns></returns>
        protected string? GetNonOffValue(PdfWidgetAnnotation widget)
        {
            if (widget != null)
            {
                var ap = widget.Elements.GetDictionary(PdfAnnotation.Keys.AP);
                if (ap != null)
                {
                    var n = ap.Elements.GetDictionary("/N");
                    if (n != null)
                    {
                        return n.Elements.Keys.FirstOrDefault(name => name != "/Off");
                    }
                }
            }
            return null;
        }

        internal override void GetDescendantNames(ref List<string> names, string? partialName)
        {
            string t = Elements.GetString(PdfAcroField.Keys.T);
            // HACK: ??? 
            if (t == "")
                t = "???";
            Debug.Assert(t != "");
            if (t.Length > 0)
            {
                if (!String.IsNullOrEmpty(partialName))
                    names.Add(partialName + "." + t);
                else
                    names.Add(t);
            }
        }

        /// <summary>
        /// Attempts to determine the visual appearance for this AcroField
        /// </summary>
        protected override void DetermineAppearance()
        {
            base.DetermineAppearance();
            if (!string.IsNullOrEmpty(ContentFontName) && DeterminedFontSize > 0.0)
                return;
            for (var i = 0; i < Annotations.Elements.Count; i++)
            {
                var widget = Annotations.Elements[i];
                if (widget.Page != null)
                {
                    var appearance = widget.Elements.GetDictionary(PdfAnnotation.Keys.AP);
                    if (appearance != null)
                    {
                        // /N -> Normal appearance, /R -> Rollover appearance, /D -> Down appearance
                        var apps = appearance.Elements.GetDictionary("/N");
                        if (apps != null)
                        {
                            var appSel = apps.Elements.GetDictionary(GetNonOffValue() ?? "Yes");
                            if (appSel != null)
                            {
                                try
                                {
                                    DetermineFontFromContent(appSel.Stream.UnfilteredValue);
                                }
                                catch
                                { }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Predefined keys of this dictionary. 
        /// The description comes from PDF 1.4 Reference.
        /// </summary>
        public new class Keys : PdfAcroField.Keys
        {
            // Pushbuttons have no additional entries.
        }
    }
}
