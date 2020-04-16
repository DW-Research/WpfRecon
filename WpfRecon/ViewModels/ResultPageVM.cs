namespace WpfRecon.ViewModels
{
    class ResultPageVM
    {
        //Running the Nmap scan and display the output to the results page 
        public ResultPageVM()
        {
                      
        }

        //display a nmap as a string to the reslusts page if the ping scan was succsessful
        public string DisplayOutput(string nmapScanResult)
        {
           
           return MainPageVM.NmapScanResults;

            
        }
    }
}

   
