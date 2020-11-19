using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange.BaseElements
{
    public abstract class SpecIfDiagramInterchangeBase
    {
        [XmlAttribute("id")]
        public string ID { get; set; } = null;

        [XmlAttribute("idRef")]
        public string IdReference { get; set; } = "";

        [XmlAttribute("revisionRef")]
        public string RevisionReference { get; set; } = "";

    }
}
