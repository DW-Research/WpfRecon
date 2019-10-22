using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRecon.Models
{
   public class CheckValidation
    {

        public bool ValidateIPv4(string ipString)
        {
            //if it is blank throw an error
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }
            // is is in the correct format if not error
            string[] splitValues = ipString.Split('.');

           if (splitValues.Length != 4)
            {
                return false;
            }
            return false;
        }

        public bool ValidateNullorEmpty(string IpAddress)
        {
            if (String.IsNullOrEmpty(IpAddress))
            {
                return false;
            }
            return false;
        }
    }
}
