using System;

namespace MauiAppExample;

public class RecruitmentSystem
{
    private readonly List<Job> jobs = new List<Job>();

    public void AddJob(Job jon)
    {
        jobs.Add(jon);
    }
    public void RemoveJob(Job job)
    {
        jobs.Remove(job);
    }
    public List<Job> GetJobs()
    {
        return jobs.ToList();
    }
}
