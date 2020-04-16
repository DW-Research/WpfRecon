using NUnit.Framework;
using System.Text.RegularExpressions;
using WpfRecon;


namespace WpfReconTests
{
    public class PingWrapperTest

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetLocalIPAddressRetrnNotNull()
        {
            /*arrange*/
            //Act  
            string returnvalue = WpfRecon.Wrappers.PingWrapper.GetLocalIPaddress();

            //assert

            Assert.NotNull(returnvalue);

        }

        [Test]
        public void TestGetLocalIPAddress()
        {
            /*arrange*/
            string Pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";

            //Act  
            string returnvalue = WpfRecon.Wrappers.PingWrapper.GetLocalIPaddress();


            //assert
            bool match = Regex.IsMatch(returnvalue, Pattern);

            Assert.AreEqual(true, match);

        }

    }
}

