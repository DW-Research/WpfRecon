using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using WpfRecon;
using System.Windows;

namespace WpfRecon.Scans
{
    public class LiveHost
    {

        //TO-DO add error codes, This is not a live host, this is not a correct IP.
        public string PingSweep(string IPaddress)
        {
            var successText = "This is not a live host";
            //var mp = new MainWindow();
            Ping p = new Ping();
            PingReply r;
            string s;
            s = IPaddress;
            r = p.Send(IPaddress);

            if (r.Status == IPStatus.Success)
            { 
                successText = "Ping to " + s.ToString() + " Successful"
                   + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                return successText;
            }
            return successText;
        }

        private void IpAddress_Validated(object sender, EventArgs e)
        {
            var mp = new MainWindow();
            if (string.IsNullOrWhiteSpace(mp.IpAddress.Text) || mp.IpAddress.Text == "")
            {
                MessageBox.Show("Please use valid IP or web address!!!");
            }
             
     
        }
    }
}   
            
            
            
        




