using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using WpfRecon.Interfaces;

namespace WpfRecon.Wrappers
{
        public class PingWrapper : IPingWrapper
        {
            public PingReply Send(string IpAddress)
            {
                var ping = new Ping();
                return ping.Send(IpAddress);
            }
        }
    }

