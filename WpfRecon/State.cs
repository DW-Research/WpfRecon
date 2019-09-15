using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRecon
{
    public static class State
    {
        public static bool SuccessfulPing { get; set; } = false;
        public static string IPAddress { get; set; } = string.Empty;
    }
}
