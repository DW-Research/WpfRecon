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
        
        private readonly NMapScan NmapScan;

        public ResultPageVM()
        {
            NmapScan = new NMapScan();
        }

        public string DisplayOutput(string nmapScanResult)
        {
            if(State.SuccessfulPing)
            {
                return NmapScan.RunScan(State.IPAddress);
            }
            return "Ping unsuccessful";
        }
    }
}

   
