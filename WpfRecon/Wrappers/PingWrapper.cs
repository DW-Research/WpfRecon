using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using WpfRecon.Interfaces;

namespace WpfRecon.Wrappers
    //This is the ICMP PingReply rapper that will allow me to conduct Nunit testing.
{
        public class PingWrapper : IPingWrapper
        {
            public PingReply Send(string IpAddress)
            {
                var ping = new Ping();
                return ping.Send(IpAddress);
            }
        // TODO: Task Number One - Do not allow words only allow for numbers and a dash
        }
    }

