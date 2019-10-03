/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class Definitions
    {
        public Definitions()
        {
            Markers = new List<Marker>();
        }

        [XmlElement("marker")]
        public List<Marker> Markers { get; set; }
    }
}
