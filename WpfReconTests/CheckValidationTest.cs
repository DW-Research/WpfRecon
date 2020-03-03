using NUnit.Framework;
using WpfRecon;


namespace WpfReconTests
{
    public class CheckValidationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIsValidIPReturnFalseWithNull()
        {
            /*arrange*/
            string testip = null;

            //Act  
            string returnvalue = WpfRecon.Models.CheckValidation.IsValidateIP(testip);

            //assert
            Assert.AreEqual("False", returnvalue);
            Assert.Pass();
        }

        [Test]
        public void TestIsValidIPAddressReturnFalseWithLetter()
        {
            /*arrange*/
            string lettersip = "helloworld";

            //Act  
            string returnvalue = WpfRecon.Models.CheckValidation.IsValidateIP(lettersip);

            //assert
            Assert.AreEqual("False", returnvalue);
            Assert.Pass();
        }

        [Test]
        public void TestIsValidIPAddressRetrunFalseWithFormaterror()
        {
            /*arrange*/
            string wrongformat1 = "1234.15.1.1";
            //Act  
            string returnvalue = WpfRecon.Models.CheckValidation.IsValidateIP(wrongformat1);

            //assert
            Assert.AreEqual("False", returnvalue);
            Assert.Pass();
        }

        [Test]
        public void TestIsValidIPAddressRetrunFalseWithFormaterror2()
        {
            /*arrange*/
            string wrongformat2 = "1.1.1.1.1.";
            //Act  
            string returnvalue = WpfRecon.Models.CheckValidation.IsValidateIP(wrongformat2);

            //assert
            Assert.AreEqual("False", returnvalue);
            Assert.Pass();
        }

        [Test]
        public void TestIsValidIPAddressRetrunFalseWithFormaterror3()
        {
            /*arrange*/
            string wrongformat3 = "192.168.L.1";
            //Act  
            string returnvalue = WpfRecon.Models.CheckValidation.IsValidateIP(wrongformat3);

            //assert
            Assert.AreEqual("False", returnvalue);
            Assert.Pass();
        }

        [Test]
        public void TestIsValidIPAddressRetrunTrueWhenCorrect()
        {
            /*arrange*/
            string correctformat = "192.168.1.1";
            //Act  
            string returnvalue = WpfRecon.Models.CheckValidation.IsValidateIP(correctformat);

            //assert
            Assert.AreEqual("True", returnvalue);
            Assert.Pass();
        }
    }
}

