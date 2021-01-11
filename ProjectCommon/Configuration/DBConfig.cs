using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCommon.Configuration
{
    /// <summary>
    /// Database configuration
    /// </summary>
    public class DBConfig : IConfig
    {
        public string Server = "localhost";
        public string UserID = "admin";
        public string Password = "Hemligt-123";
        public string DatabaseName = "DummyDB";
    }
}
