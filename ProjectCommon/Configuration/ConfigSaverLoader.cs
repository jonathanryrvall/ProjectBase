﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ProjectCommon.Configuration
{
    /// <summary>
    /// Manages loading and saving of configuration
    /// </summary>
    public static class ConfigSaverLoader
    {


        /// <summary>
        /// Try to load config from file, if it failed create a new config object and save it to file
        /// </summary>
        public static T LoadCreateDefault<T>(string path) where T : new()
        {
            T config = Load<T>(path);

            if (config == null)
            {
                config = new T();
            }

            Save(config, path);

            return config;
        }

        /// <summary>
        /// Load configuration
        /// </summary>
        public static T Load<T>(string path) where T : new()
        {
            // File exists?
            if (!File.Exists(path))
            {
                return default;
            }

            // Read file
            string xml = File.ReadAllText(path);

            // Deserialize
            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xml))
            {
                T config = (T)xsSubmit.Deserialize(reader);
                return config;
            }
        }


        /// <summary>
        /// Save configureation
        /// </summary>
        public static void Save(object config, string path)
        {
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.NewLineChars = "\r\n";
            xmlSettings.Indent = true;
            xmlSettings.IndentChars = "   ";
            xmlSettings.NewLineHandling = NewLineHandling.Replace;
            XmlSerializer xsSubmit = new XmlSerializer(config.GetType());
            using (var sww = new StreamWriter(path))
            {
                using (XmlWriter writer = XmlWriter.Create(sww, xmlSettings))
                {
                    xsSubmit.Serialize(writer, config);
                }
            }
        }



    }
}
