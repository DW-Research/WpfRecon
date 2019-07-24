using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WpfRecon.Models
{
    public class ScanResult
    {
        public string IpAdress { get; set; }
        public PingReply PingReply { get; set; }
        public int Port { get; set; }

        public override string ToString()
        {
            string successMessage = PingReply.Status == IPStatus.Success ? "Success" : "Failure";

            return "Ping to: " + IpAdress + "\n"
                + "Response delay = " + PingReply.RoundtripTime.ToString() + " ms" + "\n"
                + "Result: " + successMessage;
        }

    }
}
