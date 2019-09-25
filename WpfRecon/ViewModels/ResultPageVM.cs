using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfRecon.Scans;
using WpfRecon.Models;

namespace WpfRecon.ViewModels
{
    class ResultPageVM
    {
        //Running the Nmap scan and display the output to the results page 
        //private readonly NMapScan NmapScan;

        public ResultPageVM()
        {
            //constructor to run a new nmap scan
            //NmapScan = new NMapScan();
            
        }

        //display a nmap as a string to the reslusts page if the ping scan was succsessful
        
        //TODO: Automate the nmap scan from a succsessful ping 
        public string DisplayOutput(string nmapScanResult)
        {
            //if(State.SuccessfulPing)
            //{
            //    return NmapScan.RunScan(State.IPAddress);
            //}
            //return "Ping unsuccessful";
           return MainPageVM.NmapScanResults;

            
        }
    }
}

   
