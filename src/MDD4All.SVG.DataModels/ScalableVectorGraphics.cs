/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    [XmlRoot(ElementName = "svg", Namespace = "http://www.w3.org/2000/svg")]
    public class ScalableVectorGraphics
    {
        public ScalableVectorGraphics()
        {
            Definitions = new Definitions();
            Groups = new List<Group>();
            Rectangles = new List<Rectangle>();
            Circles = new List<Circle>();
            Polylines = new List<Polyline>();
            Texts = new List<Text>();
            Lines = new List<Line>();

            Version = "1.1";
            Width = "800";
            Height = "600";
        }



        [XmlAttribute("width")]
        public string Width { get; set; }

        [XmlAttribute("height")]
        public string Height { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlElement("defs")]
        public Definitions Definitions { get; set; }

        [XmlElement("g")]
        public List<Group> Groups { get; set; }

        [XmlElement("rect")]
        public List<Rectangle> Rectangles { get; set; }

        [XmlElement("circle")]
        public List<Circle> Circles { get; set; }

        [XmlElement("polyline")]
        public List<Polyline> Polylines { get; set; }

        [XmlElement("text")]
        public List<Text> Texts { get; set; }

        [XmlElement("line")]
        public List<Line> Lines { get; set; }



        public void LoadFromXml(string filename)
        {

        }

        public void SaveToFile(string filename)
        {
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("di", "http://www.omg.org/spec/DD/20100524/DI");
            namespaces.Add("dc", "http://www.omg.org/spec/DD/20100524/DC");
            namespaces.Add("specif", "https://specif.de/schema/v1.0/DI");

            XmlSerializer serializer = new XmlSerializer(typeof(ScalableVectorGraphics));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, this, namespaces);
            writer.Close();
        }
    }
}
