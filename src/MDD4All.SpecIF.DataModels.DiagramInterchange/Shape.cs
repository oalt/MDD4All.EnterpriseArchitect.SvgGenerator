using MDD4All.SpecIF.DataModels.DiagramInterchange.BaseElements;
using MDD4All.SpecIF.DataModels.DiagramInterchange.DiagramDefinition;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange
{

    [XmlType(TypeName = "shape", Namespace = "https://specif.de/schema/v1.0/DI")]
    [XmlRoot("shape", Namespace = "https://specif.de/schema/v1.0/DI")]
    public class Shape
    {
        public Shape()
        {

        }

        [XmlElement("resourceReference", Namespace = "https://specif.de/schema/v1.0/DI")]
        public ResourceReference ResourceReference { get; set; }

        [XmlElement("Bounds",  Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
        public Bounds Bounds { get; set; }

       
    }
}
