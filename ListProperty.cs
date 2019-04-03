
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable, XmlRoot]
    public sealed class ListProperty : CamlQueryApiBase
    {
        [XmlElement]
        public bool AutoHyperLink { get; set; }

        [XmlElement]
        public bool AutoHyperLinkNoEncoding { get; set; }

        [XmlElement]
        public bool AutoNewLine { get; set; }

        [XmlElement]
        public string Default { get; set; }

        [XmlElement]
        public bool ExpandXML { get; set; }

        [XmlElement]
        public bool HTMLEncode { get; set; }

        [XmlElement]
        public string Select { get; set; }

        [XmlElement]
        public bool StripWS { get; set; }

        [XmlElement]
        public bool URLEnconde { get; set; }

        [XmlElement]
        public bool URLEncondeAsURL { get; set; }
    }
}