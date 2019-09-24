using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WpfRecon.Scans
{
    public class NMapScan
    {
    

        public string RunScan(string IpAddress)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;

                    //TODO: Fix full scan functionality by putting all of the nmap scripts in one location or fidning a way to mane Nmap locate the rest of the scripts 

                    //this will use the nmap external tool that is stored in the External Tools folder
                    //Running the nmap tool 
                    myProcess.StartInfo.FileName = "ExternalTools//nmap.exe";
                    //Running the options
                    var sb = new StringBuilder();
                    // Fastest insain mode 
                    //sb.Append("-T5 ");
                    // Test popular ports 
                    //sb.Append("-F ");
                    //full enumeration scan 
                    // sb.Append("-A ");
                    sb.Append(IpAddress);
                    //add the arguments to the end of the nmap scan
                    myProcess.StartInfo.Arguments = sb.ToString();
                    //hide the window to avoid a popup
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.StartInfo.RedirectStandardOutput = true;
                    myProcess.StartInfo.RedirectStandardError = true;

                    

                    // myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    
                    var stdOutSb = new StringBuilder();
                    while (!myProcess.HasExited)
                    {
                        stdOutSb.Append(myProcess.StandardOutput.ReadToEnd());
                        stdOutSb.Append(myProcess.StandardError.ReadToEnd());
                    }
                       

                    return stdOutSb.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }
    }

    public class NmapEventHandler
    {
    }
}
