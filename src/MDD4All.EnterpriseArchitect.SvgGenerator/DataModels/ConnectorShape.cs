/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
#if EA_FACADE
namespace MDD4All.EAFacade.SvgGenerator.DataModels
#else
namespace MDD4All.EnterpriseArchitect.SvgGenerator.DataModels
#endif
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
