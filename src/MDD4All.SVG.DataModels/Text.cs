using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
	public class Text : PresentationElement
	{
		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }

		[XmlAttribute("text-anchor")]
		public string TextAnchor { get; set; }

		[XmlAttribute("inline-size")]
		public string InlineSize { get; set; }

		[XmlAttribute("font-family")]
		public string FontFamily { get; set; }

		[XmlAttribute("font-size")]
		public string FontSize { get; set; }

		[XmlAttribute("font-weight")]
		public string FontWeight { get; set; }

		[XmlText]
		public string DisplayedText { get; set; }

	}
}
