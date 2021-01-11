using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ProjectCommon.Extensions
{
    /// <summary>
    /// Common XML extensions
    /// </summary>
    public static class XMLExtensions
    {
        ///// <summary>
        ///// Deserialize a xml string
        ///// </summary>
        //public static T FromXML<T>(string xml)
        //{
        //    using (StringReader reader = new StringReader(xml))
        //    {
        //        return (T)new XmlSerializer(typeof(T)).Deserialize(reader);
        //    }
        //}

        /// <summary>
        /// Convert an object to xml
        /// </summary>
        public static string ToXML(this object obj)
        {
            if (obj == null)
            {
                return "";
            }
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(stringwriter, obj);
                return stringwriter.ToString();
            }
        }

        /// <summary>
        /// Save an object as an XML file
        /// </summary>
        public static void SaveXML<T>(this T data, string path)
        {
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.NewLineChars = "\r\n";
            xmlSettings.Indent = true;
            xmlSettings.IndentChars = "   ";
            xmlSettings.NewLineHandling = NewLineHandling.Replace;
            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
            using (var sww = new StreamWriter(path))
            {
                using (XmlWriter writer = XmlWriter.Create(sww, xmlSettings))
                {
                    xsSubmit.Serialize(writer, data);
                }
            }
        }
    }
}
