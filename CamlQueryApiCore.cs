﻿
//Author: Antonio Leonardo de Abreu Freire, Microsoft Certified ID: 13271836
//My profile: https://br.linkedin.com/in/antonio-leonardo
//Contacts: antonio.leonardo@outlook.com.br

using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;

namespace CamlQueryApi
{
    /// <summary>
    /// Utilitary class to define internal methods, used only on API
    /// </summary>
    internal static class CamlQueryApiSerializer
    {
        /// <summary>
        /// 
        /// </summary>
        private enum RootRemovible
        {
            Query,
            ViewFields
        }

        /// <summary>
        /// Generates a CAML Query String, based on POCO class API Xml Serialization
        /// </summary>
        /// <typeparam name="TEntity">CAML Query Entity Class</typeparam>
        /// <param name="obj">Object based on Generic defined Entity class</param>
        /// <returns>System.String</returns>
        internal static string ToCamlString<TEntity>(this TEntity obj) where TEntity : class, new()
        {
            Type currentType = typeof(TEntity);
            XmlSerializer serializer = null;
            XmlWriterSettings settings = null;
            XmlSerializerNamespaces ns = null;
            string className = currentType.Name;
            const string BEGIN_BEGIN_TAG = "<",
                         BEGIN_END_TAG = "</",
                         END_TAG = ">";
            using (StringWriter stringWriter = new StringWriter())
            {
                settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                settings.Encoding = Encoding.UTF8;

                using (XmlWriter xmlTxtWriter = XmlTextWriter.Create(stringWriter, settings))
                {
                    serializer = new XmlSerializer(currentType);
                    ns = new XmlSerializerNamespaces();
                    ns.Add("", "");
                    serializer.Serialize(xmlTxtWriter, obj, ns);
                    return (className == RootRemovible.Query.ToString() || className == RootRemovible.ViewFields.ToString()) ?
                        @stringWriter.ToString().Replace(BEGIN_BEGIN_TAG + className + END_TAG, "").Replace(BEGIN_END_TAG + className + END_TAG, "") :
                        @stringWriter.ToString();
                }
            }
        }
    }
}