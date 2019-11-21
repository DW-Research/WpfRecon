using System.Net.NetworkInformation;
using WpfRecon.Wrappers;

namespace WpfRecon.Models
{
    public class LiveHost
    {

        //This is the ICMP request that uses the Pingwrapper and interface to send a ping and display a result on the main page
        public ScanResult PingSweep(string IpAddress)
        {
            //Use the ping wrapper that is the NetworkInformation class 
            PingWrapper ping = new PingWrapper();

            if(IpAddress == "")
            {
                IpAddress = PingWrapper.GetLocalIPaddress();
                
            }
            else
                    { }
            // create a result of sending a ping to remote device by using the IpAddress that has been provided from the main page view 
            ScanResult result = new ScanResult
            {
                IpAdress = IpAddress,
                PingReply = ping.Send(IpAddress)
            };

            // create a state that is then sent to the Nmap scan if succsessfull 
            State.SuccessfulPing = result.PingReply.Status == IPStatus.Success;

            State.IPAddress = result.IpAdress;

            return result;
        }
    }
}


            
            
            
        




