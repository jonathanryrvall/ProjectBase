using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WPFProjectBase.Services
{
    /// <summary>
    /// Service that returns paths to different files / directories related to the project
    /// theese files / directories are usually a relative path to the executable
    /// </summary>
    public class PathsService
    {

        /// <summary>
        /// Config directory
        /// </summary>
        private string ConfigDirectory
        {
            get
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory + "/config";

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                return directory;
            }
        }



        /// <summary>
        /// Config file
        /// </summary>
        public string ConfigPath => ConfigDirectory + "/config.xml";
    }
}
