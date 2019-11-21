using System.Text.RegularExpressions;

namespace WpfRecon.Models
{
    public class CheckValidation
    {

        internal static string IsValidateIP(string Address)
            {
            string isValid;

            if (string.IsNullOrEmpty(Address))
            {
                //returns false if IP is not provided    
                isValid = "False";
                return isValid;
            }

            else
            {

                //Match pattern for IP address    
                string Pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
                //Regular Expression object    
                Regex check = new Regex(Pattern);
                //if not a match to the regex then return false
                if(!Regex.IsMatch(Address,Pattern))
                {
                    isValid = "False";
                    return isValid;
                }
                else
                {
                    isValid = "True";// check.IsMatch(Address, 0);
                    return isValid;
                }
                 
                
            }

             
           

        }

       
    }
}

