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
   
        public ScanResult NmapScan { get; private set; }

        public string DisplayOutput(string nmapScanResult)
        {

            ResultsPage NmapScan = new ResultsPage();
            NmapScan = NmapScan;
            return NmapScan.ToString();
        }
    }
}

   
