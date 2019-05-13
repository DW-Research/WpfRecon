using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRecon.Scans
{
    class PortList
    {
        private int start;
        private int stop;
        private int ports;

        public PortList(int starts, int stops)
        {
            start = starts;
            stop = stops;
            ports = start;
        }

        public bool MorePorts()
        {
            return (stop - ports) >= 0;
        }
        public int NextPort()
        {
            if (MorePorts())
            {
                return ports++;
            }
            return -1;
        }
    }
}
}
