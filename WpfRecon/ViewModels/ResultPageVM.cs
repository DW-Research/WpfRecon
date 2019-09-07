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
   
        public ScanResult NmapScanResult { get; private set; }

        public string DisplayOutput(string nmapScanResult)
        {

            NmapScanResult NmapScan = new NmapScanResult();
            NmapScanResult = NmapScan;
            return NmapScanResult.ToString();
        }
    }
}

   
