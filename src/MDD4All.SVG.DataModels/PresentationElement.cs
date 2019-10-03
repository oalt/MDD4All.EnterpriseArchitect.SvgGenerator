/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public abstract class PresentationElement
    {
        public PresentationElement()
        {
            Title = new Title();
            Description = new Description();
            Metadata = new Metadata();
        }

        [XmlElement("title", IsNullable = true)]
        public Title Title { get; set; }

        [XmlElement("desc", IsNullable = true)]
        public Description Description { get; set; }

        [XmlElement("metadata", IsNullable = true)]
        public Metadata Metadata { get; set; }

        [XmlAttribute("fill")]
        public string Fill { get; set; }

        [XmlAttribute("stroke")]
        public string Stroke { get; set; }

        [XmlAttribute("stroke-width")]
        public string StrokeWidth { get; set; }

        [XmlAttribute("stroke-linejoin")]
        public string StrokeLineJoin { get; set; }
    }
}
