using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Collection of helper methods.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Gets the connection string by the reference name.
        /// </summary>
        /// <param name="name">Reference name of the connection string.</param>
        /// <returns>The connection string which was referenced by name.</returns>
        public static string GetConnectionStringByName(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
