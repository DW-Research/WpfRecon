using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace WpfRecon.Scans
{
    public class NMapScan
    {
    

        public async Task<string> RunScan(string IpAddress)
        {
            try
            {
               
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;

                    //TODO: Fix full scan functionality by putting all of the nmap scripts in one location or finding a way to make Nmap locate the rest of the scripts 

                    //This will use the nmap external tool that is stored in the External Tools folder
                    //Running the nmap tool 
                    myProcess.StartInfo.FileName = "ExternalTools//nmap.exe";
                    //Running the options
                    var sb = new StringBuilder();
                    // Fast scan mode 
                    sb.Append("-T5 ");
                    // Test popular ports 
                    sb.Append("-F ");
                    //full enumeration scan 
                    sb.Append("-A ");
                    //All safe scripts
                    //sb.Append("-sC ");
                    
                    sb.Append("--script ssh-brute,telnet-brute,ftp-brute,smb-os-discovery, ");

                    //TODO: Enable /24 scans and all ports -p- 
                    //if (AllPorts_Checked.Checked)
                    //{
                    //    sb.Append("-p- ");
                    //}

                    //if (WholeNetwork_Checked.Checked)
                    //{
                    //    sb.Append(IpAddress"/24");

                    //}
                   
                    //else 
                    sb.Append(IpAddress);
                    //add the arguments to the end of the nmap scan
                    myProcess.StartInfo.Arguments = sb.ToString();
                    //hide the window to avoid a popup
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.StartInfo.RedirectStandardOutput = true;
                    myProcess.StartInfo.RedirectStandardError = true;

                    // myProcess.StartInfo.CreateNoWindow = true;
                    
                    await Task.Run(() => myProcess.Start());
                    //myProcess.Start();
                    
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
