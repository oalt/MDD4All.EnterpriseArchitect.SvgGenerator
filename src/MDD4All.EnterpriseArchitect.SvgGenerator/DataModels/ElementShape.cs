using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.EnterpriseArchitect.SvgGenerator.DataModels
{
    public class ElementShape
    {
        public string Type { get; set; } = "Class";

        public string Stereotype { get; set; } = "";

        public int BorderWidth { get; set; } = 1;

        public string StrokeDashArray { get; set; } = "";

        public string BorderColor { get; set; } = "black";

        public string FillColor { get; set; } = "white";

        public int CornerRadius { get; set; } = 0;

        public string MainShape { get; set; } = "Rectangle";

        public string MainLabel { get; set; } = "";

        public string MainLabelVerticalPosition { get; set; } = "top";

        public string MainLabelFontWeight { get; set; } = "bold";

    }
}
