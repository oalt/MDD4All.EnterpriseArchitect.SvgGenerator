/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SpecIF.DataModels.DiagramInterchange;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class Metadata
    {

        [XmlElement("shape", Namespace = "https://specif.de/schema/v1.0/DI")]
        public Shape Shape { get; set; } = null;

        [XmlElement("edge", Namespace = "https://specif.de/schema/v1.0/DI")]
        public Edge Edge { get; set; } = null;
    }
}
