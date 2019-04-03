using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable, XmlRoot]
    public sealed class Query : CamlQueryApiBase
    {
        [XmlElement]
        public Where Where { get; set; }

        [XmlElement]
        public GroupBy GroupBy { get; set; }

        [XmlElement]
        public OrderBy OrderBy { get; set; }
    }
}