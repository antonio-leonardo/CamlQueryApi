﻿
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    [Serializable, XmlRoot]
    public class FieldRefBase
    {
        [XmlAttribute]
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return this.ToCamlString();
        }
    }
}