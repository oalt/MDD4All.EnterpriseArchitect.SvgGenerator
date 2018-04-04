using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
	public class Title
	{
		[XmlText]
		public string Text { get; set; }
	}
}
