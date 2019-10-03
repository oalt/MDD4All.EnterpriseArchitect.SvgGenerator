/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels.Extensions
{
    public class SvgElement : PresentationElement
    {
        [XmlIgnore]
        public int Sequence { get; set; }
    }
}
