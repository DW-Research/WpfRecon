using System.Net.NetworkInformation;


namespace WpfRecon.Models
{
    public class ScanResult
    {
        //IpAddress is taken from the Main page and sent to the PingReply Wrapper
        public string IpAdress { get; set; }
        public PingReply PingReply { get; set; }
        

        //The string that Will be displaid is the Main page is broken down to Sussess/Failure - RHOST IP Address - Delay Time 
        public override string ToString()
        {

            //sets if the ping request was a succsess or not
            string successMessage = PingReply.Status == IPStatus.Success ? "Target Online" : "Failure";

            //IpAddres is provided from the mainpage view
            return "Ping to: " + IpAdress + " Complete" + "\n"
                + "Response delay = " + PingReply.RoundtripTime.ToString() + " ms" + "\n"
                + "Result: " + successMessage;
        }


    }
}
