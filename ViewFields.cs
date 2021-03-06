﻿using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable]
    public class ViewFields
    {
        [XmlElement]
        public FieldRefViewFields[] FieldRef { get; set; }

        public override string ToString()
        {
            return this.ToCamlString();
        }
    }
}