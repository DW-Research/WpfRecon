using System.Net.NetworkInformation;


namespace WpfRecon.Interfaces
{
    //the ping wrapper has been created to wrap the networkInformation class for testung purposes. 
    public interface IPingWrapper
    {
        //send the ping request to the target address
        PingReply Send(string IpAddress);
    }


}
