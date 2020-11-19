using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.EnterpriseArchitect.SvgGenerator.DataModels
{
    public class ConnectorShape
    {
        public string Type { get; set; } = "Connector";

        public string Stereotype { get; set; } = "";

        public string Color { get; set; } = "black";

        public string Width { get; set; } = "";

        public string StrokeDashArray { get; set; } = "";
    }
}
