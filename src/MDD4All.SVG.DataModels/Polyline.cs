/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class Polyline : PresentationElement
    {
        [XmlAttribute("points")]
        public string Points { get; set; }

        [XmlAttribute("marker-start")]
        public string MarkerStart { get; set; }

        [XmlAttribute("marker-end")]
        public string MarkerEnd { get; set; }
    }
}
