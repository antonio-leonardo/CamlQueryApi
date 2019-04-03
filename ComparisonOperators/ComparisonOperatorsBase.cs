
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable]
    public class ComparisonOperatorsBase : NullableComparisonOperatorsBase
    {
        [XmlElement]
        public Value Value { get; set; }

        public override string ToString()
        {
            return this.ToCamlString();
        }
    }
}