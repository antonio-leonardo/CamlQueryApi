
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable]
    public sealed class Value //: CamlQueryApiBase
    {
        [XmlAttribute]
        public ValueType Type { get; set; }

        [XmlAttribute]
        public bool IncludeTimeValue { get; set; }

        [XmlText]
        public string TextValue { get; set; }

        [XmlElement]
        public ListProperty[] ListProperties { get; set; }

        public override string ToString()
        {
            return this.ToCamlString();
        }
    }
}