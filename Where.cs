
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable, XmlRoot]
    public sealed class Where : LogicalJoinsBase
    {
        [XmlElement]
        public And[] And { get; set; }

        [XmlElement]
        public Or[] Or { get; set; }

        [XmlElement]
        public OrderBy OrderBy { get; set; }

        [XmlElement]
        public GroupBy GroupBy { get; set; }
    }
}