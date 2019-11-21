using System.Net;

namespace WpfRecon.Models
{
    class LocalAddress
    {
        public static string GetLocalAddress()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString(); ;
        }
    }
}
