using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels.Extensions
{
	public class SvgElement : PresentationElement
	{
		[XmlIgnore]
		public int Sequence { get; set; }
	}
}
