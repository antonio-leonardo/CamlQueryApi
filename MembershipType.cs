
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System.Xml.Serialization;

namespace CamlQueryApi
{
    public enum MembershipType
    {
        [XmlEnum(Name = "SPWeb.AllUsers")]
        SPWebAllUsers,

        [XmlEnum(Name = "SPGroup")]
        SPGroup,

        [XmlEnum(Name = "SPWeb.Groups")]
        SPWebGroups,

        [XmlEnum(Name = "CurrentUserGroups")]
        CurrentUserGroups,

        [XmlEnum(Name = "SPWeb.Users")]
        SPWebUsers
    }
}