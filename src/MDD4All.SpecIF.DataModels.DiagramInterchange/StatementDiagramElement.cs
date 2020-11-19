using MDD4All.SpecIF.DataModels.DiagramInterchange.BaseElements;
using MDD4All.SpecIF.DataModels.DiagramInterchange.DiagramDefinition;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange
{
    public class StatementDiagramElement : SpecIfDiagramInterchangeBase
    {
        [XmlElement("waypoint", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
        public List<Waypoint> Waypoints { get; set; } = new List<Waypoint>();
    }
}
