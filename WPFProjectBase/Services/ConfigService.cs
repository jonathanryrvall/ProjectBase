using ProjectCommon.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WPFProjectBase.Model.Configuration;

namespace WPFProjectBase.Services
{
    /// <summary>
    /// Service handling saving and loading of configuration
    /// </summary>
    public class ConfigService
    {
        public Config Config { get; private set; }

        public ConfigService(PathsService pathsService)
        {
            Config = ConfigSaverLoader.LoadCreateDefault<Config>(pathsService.ConfigPath);
        }
    }
}
