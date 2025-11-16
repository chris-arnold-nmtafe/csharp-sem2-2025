using MauiAppExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations;

[TestClass]
public class Lifecycle
{
    static RecruitmentSystem system;
    static TestContext testContext;
    [ClassInitialize]
    public static void setup(TestContext context) {
        system = new RecruitmentSystem();
    }
    [ClassCleanup]
    public static void cleanup() {
        //conn.Close();
    }

    [TestMethod]
    public void TestAddJob()
    {
        //Arrange
        RecruitmentSystem testSystem = new RecruitmentSystem();
        Job job = new Job() { Title = "Test" };
        //Act
        testSystem.AddJob(job);
        //Assert
        Assert.AreEqual(1, testSystem.GetJobs().Count());
    }
    [TestMethod]
    public void TestRemoveJob() {
        Job job = new Job() { Title = "Test" };
        RecruitmentSystem testSystem = new RecruitmentSystem();
        testSystem.AddJob(job);
//        testContext.WriteLine("Haaaay!!!!");
//        Job job = system.GetJobs()[0];
        Assert.AreEqual(1, testSystem.GetJobs().Count());
        testSystem.RemoveJob(job);
        Assert.AreEqual(0, testSystem.GetJobs().Count());
    }
}
