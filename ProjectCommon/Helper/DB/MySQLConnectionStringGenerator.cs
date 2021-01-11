using ProjectCommon.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCommon.Helper.DB
{
    
    /// <summary>
    /// Generates a connection string to a MySQL database based on a <see cref="DBConfig"/>
    /// </summary>
    public class MySQLConnectionStringGenerator
    {
        /// <summary>
        /// Returns the connection string generated
        /// </summary>
        public string GetConnectionString(DBConfig dbConfig)
        {
            return $"server={dbConfig.Server};userid={dbConfig.UserID};password={dbConfig.Password};database={dbConfig.DatabaseName}";
        }
    }
}
