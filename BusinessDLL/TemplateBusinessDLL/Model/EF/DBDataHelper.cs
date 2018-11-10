using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditSystemBusinessDLL.Model.EF
{
    public class DBDataHelper : IDataHelper
    {
        public DBDataHelper()
        {
        }

        public dynamic GetData(params object[] args)
        {
            string arg_str = string.Empty;
            foreach (var param in args)
            {
                arg_str += " " + param;
            }
            return  arg_str;
        }
    }
}
