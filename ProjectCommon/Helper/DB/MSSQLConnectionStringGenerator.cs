using ProjectCommon.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCommon.Helper.DB
{
   

    /// <summary>
    /// Generates a connection string to a MSSQL database based on a <see cref="DBConfig"/>
    /// </summary>
    public class MSSQLConnectionStringGenerator
    {
        /// <summary>
        /// Returns the connection string generated
        /// </summary>
        public string GetConnectionString(DBConfig dbConfig)
        {
            return $"Data Source={dbConfig.Server};Initial Catalog={dbConfig.DatabaseName};Persist Security Info=True;User ID={dbConfig.UserID};Password={dbConfig.Password};";
        }
    }

 
}
