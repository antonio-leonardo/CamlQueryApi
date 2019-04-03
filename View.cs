using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable, XmlRoot]
    public sealed class View
    {
        [XmlElement]
        public ViewFields ViewFields { get; set; }

        [XmlElement]
        public Query Query { get; set; }

        [XmlElement]
        public string RowLimit { get; set; }

        public override string ToString()
        {
            return this.ToCamlString();
        }
    }
}