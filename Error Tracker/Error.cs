using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Tracker
{
    internal static class Error
    {
        public static string Class { get; set; }
        public static string Method { get; set; }
        public static string Message { get; set; }
        public static DateTime Timestamp { get; set; }
    }
}
