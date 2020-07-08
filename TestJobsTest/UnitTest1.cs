using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TestJobsTest
{
    [TestClass]
    public class UnitTest1
    {
        
        Job test = new Job("Voldermort");

        [TestMethod]
        public void Constructor()
        {
            string expected;
            string actual;
            

            actual = test.Value;
            expected = "Voldermort";



            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test1()
        {
            string expected = null;
            string actual = null;

            actual = test.Id.ToString();
            expected = "1";


            Assert.AreEqual(expected, actual);
        }





    }
}

