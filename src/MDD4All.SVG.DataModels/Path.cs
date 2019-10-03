/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class Path : PresentationElement
    {
        [XmlAttribute("d")]
        public string Data { get; set; }

    }
}
