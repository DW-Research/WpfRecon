using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Windows;
using System.Net;

namespace WpfRecon.Scans
{

//    class PortScanner
//    {
//        string IPaddress = "IPaddress";
//        int portno = 1000;
//        IPAddress ipa = (IPAddress)Dns.GetHostAddresses(IPaddress)[0];
//        try
//    {
//        System.Net.Sockets.Socket sock =
//                new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork,
//                                              System.Net.Sockets.SocketType.Stream,
//                                              System.Net.Sockets.ProtocolType.Tcp);
//        sock.Connect(ipa, portno);
//        if (sock.Connected == true) // Port is in use and connection is successful
//            MessageBox.Show("Port is Closed");
//        sock.Close();
//    }
//    catch (System.Net.Sockets.SocketException ex)
//    {
//        if (ex.ErrorCode == 10061) // Port is unused and could not establish connection 
//            MessageBox.Show("Port is Open!");
//        else
//            MessageBox.Show(ex.Message);
//    }
//}
//    }
}
