using MDD4All.SVG.DataModels.Extensions;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
	public class Circle : SvgElement
	{
		[XmlAttribute("cx")]
		public string Cx { get; set; }

		[XmlAttribute("cy")]
		public string Cy { get; set; }

		[XmlAttribute("r")]
		public string Radius { get; set; }

		
	}
}
