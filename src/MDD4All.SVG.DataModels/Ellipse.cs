/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SVG.DataModels.Extensions;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class Ellipse : SvgElement
    {
        [XmlAttribute("cx")]
        public string Cx { get; set; }

        [XmlAttribute("cy")]
        public string Cy { get; set; }

        [XmlAttribute("rx")]
        public string RadiusX { get; set; }

        [XmlAttribute("ry")]
        public string RadiusY { get; set; }

    }
}
