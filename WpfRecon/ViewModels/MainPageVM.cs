using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfRecon.Scans;
using WpfRecon.Models;

namespace WpfRecon.ViewModels
{
    class MainPageVM
    {
        public static string NmapScanResults;
        public ScanResult ScanResult { get; private set; }

        //Dispays the output of the ping to the mainpage textblock called output.txt
        public string DisplayOutput(string IPaddress)
        {
            //return the results of the ping scan to the mainpge view
            LiveHost liveHost = new LiveHost();
            ScanResult = liveHost.PingSweep(IPaddress);

            return ScanResult.ToString();
        }

        public string LoadNmapScanInBackground()
        {
            if (State.SuccessfulPing)
            {
                var DisplayNmap = new NMapScan();
                NmapScanResults = DisplayNmap.RunScan(State.IPAddress).ToString();
                return ScanResult.ToString();
            }

            else
            {
                return "Ping unsuccessful";

            }
        }
    }
}

