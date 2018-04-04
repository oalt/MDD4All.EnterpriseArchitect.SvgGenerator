using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
	public class Marker
	{
		public Marker()
		{
			Paths = new List<Path>();
		}


		[XmlAttribute("id")]
		public string Id { get; set; }

		[XmlAttribute("markerWidth")]
		public string Width { get; set; }

		[XmlAttribute("markerHeight")]
		public string Height { get; set; }

		[XmlAttribute("refX")]
		public string XReference { get; set; }

		[XmlAttribute("refY")]
		public string YReference { get; set; }

		[XmlAttribute("orient")]
		public string Orientation { get; set; }

		[XmlAttribute("markerUnits")]
		public string Units { get; set; }

		[XmlElement("path")]
		public List<Path> Paths { get; set; }
	}
}
