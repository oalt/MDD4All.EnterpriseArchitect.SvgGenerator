/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SVG.DataModels.Extensions;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public abstract class PresentationElement
    {
        public PresentationElement()
        {
            
        }

        [XmlElement("title")]
        public Title Title { get; set; } = null;

        [XmlElement("desc")]
        public Description Description { get; set; } = null;

        [XmlElement("metadata")]
        public Metadata Metadata { get; set; } = null;

        [XmlAttribute("fill")]
        public string Fill { get; set; }

        [XmlAttribute("stroke")]
        public string Stroke { get; set; }

        [XmlAttribute("stroke-width")]
        public string StrokeWidth { get; set; }

        [XmlAttribute("stroke-linejoin")]
        public string StrokeLineJoin { get; set; }

        [XmlAttribute("stroke-dasharray")]
        public string StrokeDashArray { get; set; }
    }
}
