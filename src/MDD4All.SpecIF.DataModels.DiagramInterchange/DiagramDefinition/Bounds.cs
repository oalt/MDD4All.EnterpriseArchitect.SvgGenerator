using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange.DiagramDefinition
{
    [XmlRoot("Bounds", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
    public class Bounds
    {
        [XmlAttribute("x")]
        public double X { get; set; }

        [XmlAttribute("y")]
        public double Y { get; set; }

        [XmlAttribute("width")]
        public double Width { get; set; }

        [XmlAttribute("height")]
        public double Height { get; set; }
    }
}
