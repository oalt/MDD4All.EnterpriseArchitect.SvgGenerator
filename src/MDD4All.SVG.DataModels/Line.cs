using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
	public class Line : PresentationElement
	{
		[XmlAttribute("x1")]
		public string X1 { get; set; }

		[XmlAttribute("y1")]
		public string Y1 { get; set; }

		[XmlAttribute("x2")]
		public string X2 { get; set; }

		[XmlAttribute("y2")]
		public string Y2 { get; set; }
	}
}
