using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TestJobsTest
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void TestSettingJobId()
        {
            int expected;
            int actual;
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            actual = job1.Id;
            expected = job2.Id;



            Assert.IsFalse(expected == actual);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product Tester",   job1.Name                           );
            Assert.AreEqual("ACME",             job1.EmployerName.ToString()        );
            Assert.AreEqual("Desert",           job1.EmployerLocation.ToString()    );
            Assert.AreEqual("Quality control",  job1.JobType.ToString()             );
            Assert.AreEqual("Persistence",      job1.JobCoreCompetency.ToString()   );
        }

        [TestMethod]
        public void JobTest()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job1.Equals(job2), false);
        }



    }
}

