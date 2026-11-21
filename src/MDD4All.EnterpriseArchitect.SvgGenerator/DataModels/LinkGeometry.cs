/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
#if EA_FACADE
namespace MDD4All.EAFacade.SvgGenerator.DataModels
#else
namespace MDD4All.EnterpriseArchitect.SvgGenerator.DataModels
#endif
{
    public class LinkGeometry
    {
        public int StartX { get; set; }

        public int StartY { get; set; }

        public int EndX { get; set; }

        public int EndY { get; set; }
    }
}
