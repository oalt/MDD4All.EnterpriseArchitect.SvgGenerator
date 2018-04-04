using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
