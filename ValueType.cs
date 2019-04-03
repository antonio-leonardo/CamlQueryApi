
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System.Xml.Serialization;

namespace CamlQueryApi
{
    public enum ValueType
    {
        [XmlEnum(Name = "Boolean")]
        Boolean,

        [XmlEnum(Name = "Choice")]
        Choice,

        [XmlEnum(Name = "ContentTypeId")]
        ContentTypeId,

        [XmlEnum(Name = "Counter")]
        Counter,

        [XmlEnum(Name = "Date")]
        Date,

        [XmlEnum(Name = "DateTime")]
        DateTime,

        [XmlEnum(Name = "Int")]
        Int,

        [XmlEnum(Name = "Integer")]
        Integer,

        [XmlEnum(Name = "Guid")]
        Guid,
        [XmlEnum(Name = "Lookup")]
        Lookup,

        [XmlEnum(Name = "MultiChoice")]
        MultiChoice,

        [XmlEnum(Name = "Number")]
        Number,

        [XmlEnum(Name = "TaxonomyFieldType")]
        TaxonomyFieldType,

        [XmlEnum(Name = "Text")]
        Text,

        [XmlEnum(Name = "User")]
        User,

        [XmlEnum(Name = "UserMulti")]
        UserMulti
    }
}