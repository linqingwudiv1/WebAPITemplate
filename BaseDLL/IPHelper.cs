using System.Web;
namespace BaseDLL.Helper
{
    public static class IPHelper
    {
        public static string IP_HTTP_VIA
        { get
            {
                if (HttpContext.Current == null || 
                    HttpContext.Current.Request == null ||
                    HttpContext.Current.Request.ServerVariables == null ||
                    HttpContext.Current.Request.ServerVariables["HTTP_VIA"] == null )
                {
                    return "";
                }
                var _IP_HTTP_VIA = HttpContext.Current.Request.ServerVariables["HTTP_VIA"];
                return _IP_HTTP_VIA;
            }
        }

        public static string IP_HTTP_X_FORWARDED_FOR
        {
            get
            {
                if (HttpContext.Current == null ||
                    HttpContext.Current.Request == null ||
                    HttpContext.Current.Request.ServerVariables == null ||
                    HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] == null)
                {
                    return "";
                }
                var _IP_HTTP_X_FORWARDED_FOR = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                return _IP_HTTP_X_FORWARDED_FOR;
            }
        }

        public static string IP_REMOTE_ADDR
        {
            get
            {
                if (HttpContext.Current == null ||
                    HttpContext.Current.Request == null ||
                    HttpContext.Current.Request.ServerVariables == null ||
                    HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] == null)
                {
                    return "";
                }
                var _IP_REMOTE_ADDR = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                return _IP_REMOTE_ADDR;
            }
        }

        public static string IP_HTTP_CLIENT_IP
        {
            get
            {
                if (HttpContext.Current == null ||
                    HttpContext.Current.Request == null ||
                    HttpContext.Current.Request.ServerVariables == null ||
                    HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"] == null)
                {
                    return "";
                }
                var _IP_HTTP_CLIENT_IP = HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"];
                return _IP_HTTP_CLIENT_IP;
            }
        }

        public static string IP_UserHostAddre
        {
            get
            {
                var _IP_UserHostAddre = HttpContext.Current.Request.UserHostAddress;
                return _IP_UserHostAddre;
            }
        }
    }
}
