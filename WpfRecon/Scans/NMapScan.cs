using System;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace WpfRecon.Models
{
    public class NMapScan
    {
    

        public async Task<string> RunScan(string IpAddress)
        {
            try
            {
                LocalAddress localAddress = new LocalAddress();
               
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;


                    //This will use the nmap external tool that is stored in the External Tools folder
                    //Running the nmap tool 
                    myProcess.StartInfo.FileName = "ExternalTools//nmap.exe";
                    //Running the options
                    var sb = new StringBuilder();
                    // Fast scan mode 
                    sb.Append("-T4 ");
                    
                    //if the mainpage All Ports checkbox was checked then it will run a all ports -p- argument
                    
                    if (MainPage.AllPortCheck == true)
                    {
                        sb.Append("-Pn ");
                        sb.Append("-p- ");
                      
                    }
                    else //if not checked then it will run a full enumeration scan on the target
                    {
                        //full enumeration scan 
                        sb.Append("-A ");
                        sb.Append("-Pn ");
                        //smb enumeration as this port has a poor security track record.
                        //Brute force SSH, Telnet, FTP
                        sb.Append("--script ssh-brute,telnet-brute,ftp-brute,smb-os-discovery, ");

                        // Test popular ports 
                        sb.Append("-F ");
                    }
                    //if the Whole Network check box was ticked the scanner will scan a whole class C network.
                    if (MainPage.WholeNetworkCheck == true)
                    {
                        sb.Append("-Pn ");
                        sb.Append(IpAddress + "/24 ");

                    }

                    //local network scan takes local ip from dns and scans class subnet
                    if (MainPage.LocalNetworkCheck == true)
                    {
                        sb.Append(IpAddress + "/24");
                    }
                    //if not selected it will just target the IP Adress provided
                    else
                    {
                        sb.Append(IpAddress);
                    }
                    //add the arguments to the end of the nmap scan
                    myProcess.StartInfo.Arguments = sb.ToString();
                    //hide the window to avoid a popup
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.StartInfo.RedirectStandardOutput = true;
                    myProcess.StartInfo.RedirectStandardError = true;

                 
                    
                    await Task.Run(() => myProcess.Start());
                    
                    //outputs the result as a string to the results page. 
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

    
}
