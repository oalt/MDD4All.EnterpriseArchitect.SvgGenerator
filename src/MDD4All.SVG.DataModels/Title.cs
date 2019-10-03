/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class Title
    {
        [XmlText]
        public string Text { get; set; }
    }
}
