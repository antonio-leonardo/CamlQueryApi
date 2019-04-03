
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable]
    public class LogicalJoinsArrayBase
    {
        [XmlElement]
        public BeginsWith[] BeginsWith { get; set; }

        [XmlElement]
        public Contains[] Contains { get; set; }

        [XmlElement]
        public DateRangesOverlap DateRangesOverlap { get; set; }

        [XmlElement]
        public Eq[] Eq { get; set; }
        
        [XmlElement]
        public Geq[] Geq { get; set; }

        [XmlElement]
        public Gt[] Gt { get; set; }

        [XmlElement]
        public In[] In { get; set; }

        [XmlElement]
        public Includes[] Includes { get; set; }

        [XmlElement]
        public IsNotNull[] IsNotNull { get; set; }

        [XmlElement]
        public IsNull[] IsNull { get; set; }

        [XmlElement]
        public Leq[] Leq { get; set; }

        [XmlElement]
        public Lt[] Lt { get; set; }

        [XmlElement]
        public Neq[] Neq { get; set; }

        [XmlElement]
        public NotIncludes[] NotIncludes { get; set; }

        public override string ToString()
        {
            return this.ToCamlString();
        }
    }
}