/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SpecIF.DataModels.DiagramInterchange;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class Metadata
    {
        [XmlElement("eaType")]
        public string EaType { get; set; }

        [XmlElement("resourceDiagramElement", Namespace = "http://specif.de")]
        public ResourceDiagramElement ResourceDiagramElement { get; set; } = null;

        [XmlElement("statementDiagramElement", Namespace = "http://specif.de")]
        public StatementDiagramElement StatementDiagramElement { get; set; } = null;
    }
}
