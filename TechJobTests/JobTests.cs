using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(job2.Id, job1.Id + 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.AreEqual("Product tester", job.Name);
            Assert.AreEqual("ACME", job.EmployerName.ToString());
            Assert.AreEqual("Desert", job.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job.JobType.ToString());
            Assert.AreEqual("Persistence", job.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestJobsToStringBlankBeforeAfter()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.AreEqual('\n', job.ToString()[0]);
            Assert.AreEqual('\n', job.ToString()[job.ToString().Length - 1]);
        }

        [TestMethod]
        public void TestJobsToStringData()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("ID: 5", job.ToString().Split('\n')[1]);
            Assert.AreEqual("Name: Product tester", job.ToString().Split('\n')[2]);
            Assert.AreEqual("Employer: ACME", job.ToString().Split('\n')[3]);
            Assert.AreEqual("Location: Desert", job.ToString().Split('\n')[4]);
            Assert.AreEqual("Position Type: Quality control", job.ToString().Split('\n')[5]);
            Assert.AreEqual("Core Competency: Persistence", job.ToString().Split('\n')[6]);

        }
    }
}
