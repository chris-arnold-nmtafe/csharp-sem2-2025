using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WpfApp1 {
    /// <summary>
    /// 
    /// </summary>
    [Bauble(Name = "Santy", NthDayOfChristmas = 5)]
    public class Job {
        public string Title { get; set; }
        public float Cost { get; set; }
        public DateTime CreationDate { get; set; }
    }
    public class Contractor {
        public string Name { get; set; }
    }
    public class MediaItem {
        public string ID { get; set; }
}
    public class RecruitmentSystem {
        private readonly List<Job> jobs = new List<Job>();
        private readonly List<Contractor> ctors = new List<Contractor>();
        public RecruitmentSystem() {
        }
        public void AddJob(Job job) {
            jobs.Add(job);
        }
        public void RemoveJob(Job job) {
            jobs.Remove(job);
        }
        public List<Contractor> GetContractors() {
            return ctors.ToList();
        }
        public List<Job> GetJobs() {
            return jobs.ToList();
        }
    }
    public class BaubleAttribute : Attribute {
        public string Name { get; set; }
        public int NthDayOfChristmas { get; set; }
    }

    public class JasonSaver {
        void saveEverything(RecruitmentSystem system) {
            List<Contractor> cs=system.GetContractors();
            List<Job> js=system.GetJobs();
            Container c = new Container(js,cs);
            string encoded=JsonConvert.SerializeObject(c);
        }
        (List<Job>,List<Contractor>) loadEverything() {
            string encoded = "";
            Container c = JsonConvert.DeserializeObject<Container>(encoded)!;
            return (c.jobs, c.contractors);
        }
        private class Container {
            public List<Job> jobs;
            public List<Contractor> contractors;
            public Container(List<Job> jobs, List<Contractor> contractors) {
                this.jobs = jobs;
                this.contractors = contractors;
            }
        }
        //public class SerialisedMediaItem {
        //    public SerialisedMediaItem(MediaItem item) {
        //        ID = item.ID;
        //        Picture = item.Picture.Url;
        //    }
        //    public string ID { get; set; }
        //    public byte[] Picture { get; set; }
        //    public MediaItem createMediaItem() {
        //        return new MediaItem() {
        //            ID = ID,
        //            Picture = Image.LoadFromUrl()
        //        };
        //    }
        //}
    }
}
