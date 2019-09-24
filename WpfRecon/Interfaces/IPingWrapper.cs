using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WpfRecon.Interfaces
{
    //the ping wrapper has been created to wrap the networkInformation class for testung purposes. 
    public interface IPingWrapper
    {
        PingReply Send(string IpAddress);
    }


}
