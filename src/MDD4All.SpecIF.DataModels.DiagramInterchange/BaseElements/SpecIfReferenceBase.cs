using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange.BaseElements
{
    public abstract class SpecIfReferenceBase
    {
        [XmlAttribute("id")]
        public string IdReference { get; set; } = "";

        [XmlAttribute("revision")]
        public string RevisionReference { get; set; } = "";
    }
}
