using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WpfRecon.Interfaces
{
    public interface IPingWrapper
    {
        PingReply Send(string IpAddress);
    }


}
