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
                    //this will use the nmap external tool that is stored in the External Tools folder
                    myProcess.StartInfo.WorkingDirectory = "ExternalTools/";
                    //Running the nmap tool 
                    myProcess.StartInfo.FileName = "nmap.exe";
                    //Running the options
                    var sb = new StringBuilder();
                    // show version option
                    sb.Append("-sV ");
                    // running the 
                    sb.Append("-A ");
                    sb.Append("-sC ");
                    sb.Append(IpAddress);
                    myProcess.StartInfo.Arguments = sb.ToString();
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
