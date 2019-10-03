/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class Metadata
    {
        [XmlElement("eaType")]
        public string EaType { get; set; }
    }
}
