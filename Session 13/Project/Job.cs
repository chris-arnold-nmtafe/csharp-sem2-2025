using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Job
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public float Cost { get; set; }
        public bool Completed { get; set; }
        public Contractor AssignedContractor { get; set; }
        public Job(string title,float cost) {
            Date = DateTime.Now;
            Completed = false;
            AssignedContractor = null;
            Title = title;
            Cost = cost;
        }
        public override string ToString() {
            return $"{Title}—{Cost}";
        }
    }
}
