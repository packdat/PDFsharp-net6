// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Drawing;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.Annotations.enums;

namespace PdfSharp.Pdf.Annotations
{
    /// <summary>
    /// Represents a text annotation.
    /// </summary>
    public sealed class PdfWidgetAnnotation : PdfAnnotation
    {
        internal PdfWidgetAnnotation()
        {
            Initialize();
        }

        internal PdfWidgetAnnotation(PdfDocument document)
            : base(document)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfWidgetAnnotation"/> with the specified dictionary.
        /// </summary>
        /// <param name="dict"></param>
        public PdfWidgetAnnotation(PdfDictionary dict)
            : base(dict)
        {
            if (dict.Elements.GetString(PdfAnnotation.Keys.Subtype) != "/Widget")
                throw new PdfSharpException("PdfWidgetAnnotation not initialized with the /Widget Subtype");
            DetermineAppearance();
        }

        void Initialize()
        {
            Elements.SetName(Keys.Subtype, "/Widget");
        }

        /// <summary>
        /// Gets or sets the background color of the field.
        /// </summary>
        public XColor BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                if (BackColor.IsEmpty)
                    return;

                if (!Elements.ContainsKey(Keys.MK))
                    Elements.Add(Keys.MK, new PdfDictionary());
                var colArray = new PdfArray();
                colArray.Elements.Add(new PdfReal(value.R / 255.0));
                colArray.Elements.Add(new PdfReal(value.G / 255.0));
                colArray.Elements.Add(new PdfReal(value.B / 255.0));
                var mk = Elements.GetDictionary(Keys.MK)!;
                mk.Elements["/BG"] = colArray;
            }
        }
        XColor backColor = XColor.Empty;

        /// <summary>
        /// Gets or sets the border color of the field.
        /// </summary>
        public XColor BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                if (borderColor.IsEmpty)
                    return;

                if (!Elements.ContainsKey(Keys.MK))
                    Elements.Add(Keys.MK, new PdfDictionary());
                var colArray = new PdfArray();
                colArray.Elements.Add(new PdfReal(value.R / 255.0));
                colArray.Elements.Add(new PdfReal(value.G / 255.0));
                colArray.Elements.Add(new PdfReal(value.B / 255.0));
                var mk = Elements.GetDictionary(Keys.MK)!;
                mk.Elements["/BC"] = colArray;
            }
        }
        XColor borderColor = XColor.Empty;

        /// <summary>
        /// Gets or sets the Rotation of this Widget in counter-clockwise direction.
        /// </summary>
        public int Rotation
        {
            get
            {
                var mk = Elements.GetDictionary(Keys.MK);
                if (mk != null && mk.Elements.ContainsKey("/R"))
                    return mk.Elements.GetInteger("/R");
                return 0;
            }
            set
            {
                if (!Elements.ContainsKey(Keys.MK))
                    Elements.Add(Keys.MK, new PdfDictionary());
                var mk = Elements.GetDictionary(Keys.MK)!;
                mk.Elements.SetInteger("/R", value);
            }
        }

        /// <summary>
        /// Gets or sets the placement of the widget's caption relative to it's icon<br></br>
        /// Only applies to <see cref="PdfPushButtonField"/>s
        /// </summary>
        public CaptionPosition CaptionPlacement
        {
            get
            {
                var mk = Elements.GetDictionary(Keys.MK);
                if (mk != null && mk.Elements.ContainsKey("/TP"))
                    return (CaptionPosition)mk.Elements.GetInteger("/TP");
                return CaptionPosition.CaptionOnly;
            }
            set
            {
                if (!Elements.ContainsKey(Keys.MK))
                    Elements.Add(Keys.MK, new PdfDictionary());
                var mk = Elements.GetDictionary(Keys.MK)!;
                mk.Elements.SetInteger("/TP", (int)value);
            }
        }

        /// <summary>
        /// Gets or sets the annotation’s highlighting mode, the visual effect to be used when
        /// the mouse button is pressed or held down inside its active area
        /// </summary>
        public HighlightingMode Highlighting
        {
            get
            {
                var mode = Elements.GetName(Keys.H);
                return mode switch
                {
                    "/N" => HighlightingMode.None,
                    "/I" => HighlightingMode.Invert,
                    "/O" => HighlightingMode.Outline,
                    "/P" => HighlightingMode.Push,
                    "/T" => HighlightingMode.Toggle,
                    _ => HighlightingMode.Invert
                };
            }
            set
            {
                switch (value)
                {
                    case HighlightingMode.None:
                        Elements.SetName(Keys.H, "/N");
                        break;
                    case HighlightingMode.Invert:
                        Elements.SetName(Keys.H, "/I");
                        break;
                    case HighlightingMode.Outline:
                        Elements.SetName(Keys.H, "/O");
                        break;
                    case HighlightingMode.Push:
                        Elements.SetName(Keys.H, "/P");
                        break;
                    case HighlightingMode.Toggle:
                        Elements.SetName(Keys.H, "/T");
                        break;
                }
            }
        }

        /// <summary>
        /// Gets or sets the normal Caption of this Annotation.<br></br>
        /// Only applies to <see cref="PdfButtonField"/>s
        /// </summary>
        /// <remarks>see PdfReference 1.7, Chapter 12.5.6.19: Widget Annotations</remarks>
        public string? NormalCaption
        {
            get { return GetMkString("/CA"); }
            set { SetMkString("/CA", value); }
        }

        /// <summary>
        /// Gets or sets the rollover Caption of this Annotation which shall be displayed
        /// when the user rolls the cursor into its active area without pressing the mouse button.<br></br>
        /// Only applies to <see cref="PdfPushButtonField"/>s
        /// </summary>
        public string? RolloverCaption
        {
            get { return GetMkString("/RC"); }
            set { SetMkString("/RC", value); }
        }

        /// <summary>
        /// Gets or sets the down Caption of this Annotation which shall be displayed
        /// when the mouse button is pressed within its active area.<br></br>
        /// Only applies to <see cref="PdfPushButtonField"/>s
        /// </summary>
        public string? DownCaption
        {
            get { return GetMkString("/AC"); }
            set { SetMkString("/AC", value); }
        }

        /// <summary>
        /// The widget annotation’s normal icon, which shall be displayed when it is not interacting with the user.
        /// Only applies to <see cref="PdfPushButtonField"/>s
        /// </summary>
        public PdfFormXObject? NormalIcon
        {
            get { return GetMkForm("/I"); }
            set { SetMkForm("/I", value); }
        }

        /// <summary>
        /// The widget annotation’s rollover icon, which shall be displayed
        /// when the user rolls the cursor into its active area without pressing the mouse button.
        /// Only applies to <see cref="PdfPushButtonField"/>s
        /// </summary>
        public PdfFormXObject? RolloverIcon
        {
            get { return GetMkForm("/RI"); }
            set { SetMkForm("/RI", value); }
        }

        /// <summary>
        /// The widget annotation’s alternate (down) icon, which shall be displayed
        /// when the mouse button is pressed within its active area.
        /// Only applies to <see cref="PdfPushButtonField"/>s
        /// </summary>
        public PdfFormXObject? DownIcon
        {
            get { return GetMkForm("/IX"); }
            set { SetMkForm("/IX", value); }
        }


        /// <summary>
        /// Get the parent-field of this Widget, if it is the child of a <see cref="PdfAcroField"/>.
        /// </summary>
        public PdfObject ParentField
        {
            get
            {
                return Elements.GetObject(Keys.Parent) ?? new PdfNullObject();
            }
            internal set { Elements.SetReference(Keys.Parent, value); }
        }

        internal override void PrepareForSave()
        {
            base.PrepareForSave();
            if (Border.Width > 0 && Border.BorderStyle != PdfAnnotationBorderStyle.None && !BorderColor.IsEmpty)
            {
                // the /BS dictionary does not support border radii, use /Border for these cases
                if (Border.HorizontalRadius > 0 || Border.VerticalRadius > 0)
                {
                    var borderArray = new PdfArray(Owner);
                    borderArray.Elements.Add(new PdfInteger(Border.HorizontalRadius));
                    borderArray.Elements.Add(new PdfInteger(Border.VerticalRadius));
                    borderArray.Elements.Add(new PdfInteger(Border.Width));
                    if (Border.DashPattern?.Length > 0)
                    {
                        var dashArray = new PdfArray(Owner);
                        foreach (var a in Border.DashPattern)
                            dashArray.Elements.Add(new PdfInteger(a));
                        borderArray.Elements.Add(dashArray);
                    }
                    Elements[Keys.Border] = borderArray;
                    Elements.Remove(Keys.BS);
                }
                else
                {
                    var bs = new PdfDictionary(Owner);
                    bs.Elements.Add("/W", new PdfInteger(Border.Width));
                    bs.Elements.Add("/S", new PdfName(Border.BorderStyle switch
                    {
                        PdfAnnotationBorderStyle.Solid => "/S",
                        PdfAnnotationBorderStyle.Dashed => "/D",
                        PdfAnnotationBorderStyle.Beveled => "/B",
                        PdfAnnotationBorderStyle.Inset => "/I",
                        _ => "/U"
                    }));
                    if (Border.DashPattern?.Length > 0)
                    {
                        var dashArray = new PdfArray(Owner);
                        foreach (var a in Border.DashPattern)
                            dashArray.Elements.Add(new PdfInteger(a));
                        bs.Elements.Add("/D", dashArray);
                    }
                    Elements[Keys.BS] = bs;
                    Elements.Remove(Keys.Border);
                }
            }
        }

        private string? GetMkString(string key)
        {
            var mk = Elements.GetDictionary(Keys.MK);
            if (mk != null && mk.Elements.ContainsKey(key))
                return mk.Elements.GetString(key);
            return null;
        }

        private void SetMkString(string key, string? value)
        {
            if (!Elements.ContainsKey(Keys.MK) && value == null)
                return;
            if (!Elements.ContainsKey(Keys.MK))
                Elements.Add(Keys.MK, new PdfDictionary());
            var mk = Elements.GetDictionary(Keys.MK)!;
            if (value != null)
                mk.Elements.SetString(key, value);
            else
                mk.Elements.Remove(key);
        }

        private PdfFormXObject? GetMkForm(string key)
        {
            var mk = Elements.GetDictionary(Keys.MK);
            if (mk != null)
            {
                var dict = mk.Elements.GetDictionary(key);
                if (dict != null)
                    return new PdfFormXObject(dict);
            }
            return null;
        }

        private void SetMkForm(string key, PdfFormXObject? value)
        {
            if (!Elements.ContainsKey(Keys.MK) && value == null)
                return;
            if (!Elements.ContainsKey(Keys.MK))
                Elements.Add(Keys.MK, new PdfDictionary());
            var mk = Elements.GetDictionary(Keys.MK)!;
            if (value != null)
                mk.Elements.SetReference(key, value);
            else
                mk.Elements.Remove(key);
        }

        private void DetermineAppearance()
        {
            DetermineBorder();

            var mk = Elements.GetDictionary(Keys.MK);     // 12.5.6.19
            if (mk != null)
            {
                var bc = mk.Elements.GetArray("/BC");
                if (bc == null || bc.Elements.Count == 0)
                    borderColor = XColor.Empty;
                else if (bc.Elements.Count == 1)
                    borderColor = XColor.FromGrayScale(bc.Elements.GetReal(0));
                else if (bc.Elements.Count == 3)
                    borderColor = XColor.FromArgb((int)Math.Round(bc.Elements.GetReal(0) * 255.0), (int)Math.Round(bc.Elements.GetReal(1) * 255.0), (int)Math.Round(bc.Elements.GetReal(2) * 255.0));
                else if (bc.Elements.Count == 4)
                    borderColor = XColor.FromCmyk(bc.Elements.GetReal(0), bc.Elements.GetReal(1), bc.Elements.GetReal(2), bc.Elements.GetReal(3));

                var bg = mk.Elements.GetArray("/BG");
                if (bg == null || bg.Elements.Count == 0)
                    backColor = XColor.Empty;
                else if (bg.Elements.Count == 1)
                    backColor = XColor.FromGrayScale(bg.Elements.GetReal(0));
                else if (bg.Elements.Count == 3)
                    backColor = XColor.FromArgb((int)Math.Round(bg.Elements.GetReal(0) * 255.0), (int)Math.Round(bg.Elements.GetReal(1) * 255.0), (int)Math.Round(bg.Elements.GetReal(2) * 255.0));
                else if (bg.Elements.Count == 4)
                    backColor = XColor.FromCmyk(bg.Elements.GetReal(0), bg.Elements.GetReal(1), bg.Elements.GetReal(2), bg.Elements.GetReal(3));
            }
        }

        /// <summary>
        /// <see cref="PdfPushButtonField"/>s only:<br></br>
        /// Specifies where to position the text of the widget annotation’s caption relative to its icon
        /// </summary>
        public enum CaptionPosition
        {
            /// <summary>
            /// No icon, only caption
            /// </summary>
            CaptionOnly = 0,
            /// <summary>
            /// No caption, icon only
            /// </summary>
            IconOnly,
            /// <summary>
            /// Caption is placed below the icon
            /// </summary>
            BelowIcon,
            /// <summary>
            /// Caption is placed above the icon
            /// </summary>
            AboveIcon,
            /// <summary>
            /// Caption is placed right of the icon
            /// </summary>
            RightOfIcon,
            /// <summary>
            /// Caption is placed left of the icon
            /// </summary>
            LeftOfIcon,
            /// <summary>
            /// Caption is overlaid directly on the icon
            /// </summary>
            Overlaid
        }

        /// <summary>
        /// The annotation’s highlighting mode, the visual effect to be used when
        /// the mouse button is pressed or held down inside its active area
        /// </summary>
        public enum HighlightingMode
        {
            /// <summary>
            /// No highlighting
            /// </summary>
            None,
            /// <summary>
            /// Invert the contents of the annotation rectangle
            /// </summary>
            Invert,
            /// <summary>
            /// Invert the annotation’s border
            /// </summary>
            Outline,
            /// <summary>
            /// Display the annotation’s down appearance, if any
            /// </summary>
            Push,
            /// <summary>
            /// Same as <see cref="Push"/> (which is preferred)
            /// </summary>
            Toggle
        }

        /// <summary>
        /// Predefined keys of this dictionary.
        /// </summary>
        internal new class Keys : PdfAnnotation.Keys
        {
            /// <summary>
            /// (Optional) The annotation’s highlighting mode, the visual effect to be used when
            /// the mouse button is pressed or held down inside its active area:
            ///   N (None) No highlighting.
            ///   I (Invert) Invert the contents of the annotation rectangle.
            ///   O (Outline) Invert the annotation’s border.
            ///   P (Push) Display the annotation’s down appearance, if any. If no down appearance is defined,
            ///     offset the contents of the annotation rectangle to appear as if it were being pushed below
            ///     the surface of the page.
            ///   T (Toggle) Same as P (which is preferred).
            /// A highlighting mode other than P overrides any down appearance defined for the annotation. 
            /// Default value: I.
            /// </summary>
            [KeyInfo(KeyType.Name | KeyType.Optional)]
            public const string H = "/H";

            /// <summary>
            /// (Optional) An appearance characteristics dictionary to be used in constructing a dynamic 
            /// appearance stream specifying the annotation’s visual presentation on the page.
            /// The name MK for this entry is of historical significance only and has no direct meaning.
            /// </summary>
            [KeyInfo(KeyType.Dictionary | KeyType.Optional)]
            public const string MK = "/MK";

            /// <summary>
            /// (Required if this widget annotation is one of multiple children in a field; absent otherwise)
            /// An indirect reference to the widget annotation’s parent field.
            /// A widget annotation may have at most one parent; that is, it can be included in the Kids array of at most one field
            /// </summary>
            [KeyInfo(KeyType.Optional)]
            public const string Parent = "/Parent";

            public static DictionaryMeta Meta => _meta ??= CreateMeta(typeof(Keys));

            static DictionaryMeta? _meta;
        }

        /// <summary>
        /// Gets the KeysMeta of this dictionary type.
        /// </summary>
        internal override DictionaryMeta Meta => Keys.Meta;
    }
}
