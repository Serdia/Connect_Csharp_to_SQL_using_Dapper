using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    //  so when you say Helper.CnnVal it's gonna lookup which connecton string to get out of my App.config and return that value
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            // the way to get connection string. This will lookup the connection string from the name
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
