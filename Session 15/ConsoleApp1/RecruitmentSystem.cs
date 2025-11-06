using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Job {
        public string Title { get; set; }
        public float Cost { get; set; }
        public DateTime CreationDate { get; set; }
    }
    class RecruitmentSystem
    {
        private readonly List<Job> jobs=new List<Job>();
        public RecruitmentSystem() { 
        }
        public void AddJob(Job job) {
            jobs.Add(job);
        }
        public void RemoveJob(Job job) {
            jobs.Remove(job); 
        }
    }
}
