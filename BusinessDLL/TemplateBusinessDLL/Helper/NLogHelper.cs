using log4net;

namespace AuditSystemBusinessDLL.Helper
{
    /// <summary>
    /// 日志帮助器
    /// </summary>
    static public class NLogHelper
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly ILog loginfo = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// NLOG
        /// </summary>
        public static NLog.Logger NLogger = NLog.LogManager.GetCurrentClassLogger();
    }
}
