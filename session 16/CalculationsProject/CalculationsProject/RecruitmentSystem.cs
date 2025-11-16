using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsProject
{
    public class RecruitmentSystem
    {
        private static readonly List<Job> jobs = new List<Job>();
        public void AddJob(Job job) {
            jobs.Add(job);
        }
        public void RemoveJob(Job job) {
            jobs.Remove(job);
        }
        public List<Job> GetJobs() {
            return jobs.ToList();
        }
    }

    public class Job {
        public string Title { get; set; }
    }
}
