using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditSystemBusinessDLL.Static
{
    class ConnectionHelper
    {
        public static string AuditDBConnString
        { get
            {
                return ConfigurationManager.ConnectionStrings["AuditDB"].ConnectionString;
            }
        }

        public static IList<T> AuditDBQuery<T>(string querysql)
        {
            using (SqlConnection conn = new SqlConnection(AuditDBConnString))
            {
                return conn.Query<T>(querysql).ToList();
            }
        }
    }
}
