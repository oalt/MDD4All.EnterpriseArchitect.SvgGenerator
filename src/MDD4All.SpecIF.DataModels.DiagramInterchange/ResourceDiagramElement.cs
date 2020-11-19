using MDD4All.SpecIF.DataModels.DiagramInterchange.BaseElements;
using MDD4All.SpecIF.DataModels.DiagramInterchange.DiagramDefinition;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange
{
    public class ResourceDiagramElement : SpecIfDiagramInterchangeBase
    {
        [XmlElement("Bounds",  Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
        public Bounds Bounds { get; set; }
    }
}
