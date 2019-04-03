

//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable, XmlRoot("FieldRef")]
    public sealed class FieldRefViewFields : FieldRefBase
    {
        [XmlIgnore]
        public string Alias { get; set; }

        [XmlIgnore]
        public bool Ascending { get; set; }

        [XmlIgnore]
        public string CreateURL { get; set; }

        [XmlIgnore]
        public string DisplayName { get; set; }

        [XmlIgnore]
        public bool Explicit { get; set; }

        [XmlIgnore]
        public string Format { get; set; }

        [XmlIgnore]
        public string ID { get; set; }

        [XmlIgnore]
        public string Key { get; set; }

        [XmlIgnore]
        public string List { get; set; }

        [XmlIgnore]
        public bool LookupId { get; set; }

        [XmlIgnore]
        public string RefType { get; set; }

        [XmlIgnore]
        public string ShowField { get; set; }

        [XmlIgnore]
        public bool TextOnly { get; set; }

        [XmlIgnore]
        public string Type { get; set; }

        public override string ToString()
        {
            return this.ToCamlString();
        }
    }
}