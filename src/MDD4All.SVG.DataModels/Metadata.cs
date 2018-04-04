using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
	public class Metadata
	{
		[XmlElement("eaType")]
		public string EaType { get; set; }
	}
}
