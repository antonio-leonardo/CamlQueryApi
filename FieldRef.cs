
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable, XmlRoot]
    public sealed class FieldRef : FieldRefBase
    {
        [XmlAttribute]
        public string Alias { get; set; }

        [XmlAttribute]
        public bool Ascending { get; set; }

        [XmlAttribute]
        public string CreateURL { get; set; }

        [XmlAttribute]
        public string DisplayName { get; set; }

        [XmlAttribute]
        public bool Explicit { get; set; }

        [XmlAttribute]
        public string Format { get; set; }

        [XmlAttribute]
        public string ID { get; set; }

        [XmlAttribute]
        public string Key { get; set; }

        [XmlAttribute]
        public string List { get; set; }

        [XmlAttribute]
        public bool LookupId { get; set; }

        [XmlAttribute]
        public string RefType { get; set; }

        [XmlAttribute]
        public string ShowField { get; set; }

        [XmlAttribute]
        public bool TextOnly { get; set; }

        [XmlAttribute]
        public string Type { get; set; }
    }
}