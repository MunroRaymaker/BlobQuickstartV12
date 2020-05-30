using System;
using System.Xml.Serialization;

namespace BlobQuickstartV12
{
    [XmlType("book")]
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public string Genre { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("publish_date")]
        public DateTime Published { get; set; }
    }
}