using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace JKO.Dao.Connection
{
    class ConnectString
    {
        public static string Azure =>
            ConfigurationManager.ConnectionStrings["JKO"].ConnectionString;
    }
}
