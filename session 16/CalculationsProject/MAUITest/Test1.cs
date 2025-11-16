using MauiAppExample;
using Microsoft.VisualStudio.TestPlatform.Utilities;
namespace MAUITest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        RecruitmentSystem rs=new RecruitmentSystem();
        Job job=new Job() {Title="Do Things for Money"};
        rs.AddJob(job);
        Assert.AreEqual(1,rs.GetJobs().Count());
    }
}
