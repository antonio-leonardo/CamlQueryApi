﻿using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable, XmlRoot]
    public sealed class Query
    {
        [XmlElement]
        public Where Where { get; set; }

        [XmlElement]
        public GroupBy GroupBy { get; set; }

        [XmlElement]
        public OrderBy OrderBy { get; set; }

        public override string ToString()
        {
            return this.ToCamlString();
        }
    }
}