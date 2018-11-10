using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditSystemBusinessDLL.Model.EF
{
    /// <summary>
    /// 作为实例
    /// </summary>
    public interface IDataHelper
    {
        dynamic GetData(params object [] args);
    }
}
