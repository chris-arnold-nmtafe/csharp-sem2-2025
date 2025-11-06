using WpfApp1;

namespace RecruitmentTests {
    [TestClass]
    public sealed class Test1 {
        [TestMethod]
        public void TestAddJob() {
            //Arrange
            RecruitmentSystem system = new RecruitmentSystem();
//            Assert.AreEqual(system.GetJobs().Count,0);
            Job job = new Job() {
                Title = "mAKE FooD",
                Cost = 1,
                CreationDate = DateTime.Now
            };
            //Act
            system.AddJob(job);
            //Assert
            Assert.AreEqual(system.GetJobs().Count,1);
        }
        [TestMethod]
        public void TestRemoveJob() {
            //Arrange
            RecruitmentSystem system = new RecruitmentSystem();
            Job job = new Job() {
                Title="Doing Things",
                Cost = 2,
                CreationDate= DateTime.Now
            };
            system.AddJob(job);
            Assert.AreEqual(system.GetJobs().Count, 1);
            //Act
            system.RemoveJob(job);
            //Assert
            foreach (Job j in system.GetJobs()) {
                if (j == job) {
                    Assert.Fail();
                }
            }
            //Assert.AreEqual(system.GetJobs().Count, 0);
        }

    }
}
