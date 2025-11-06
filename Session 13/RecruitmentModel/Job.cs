using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecruitmentModel
{
    /// <summary>
    /// 
    /// </summary>
    [PrimaryKey("ID")]
    public class Job
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public float Cost { get; set; }
        public bool Completed { get; set; }
        //public ContractorEntity AssignedContractor { get; set; }
        public Job() { }
        public Job(string title,float cost) {
            Date = DateTime.Now;
            Completed = false;
//            AssignedContractor = null;
            Title = title;
            Cost = cost;
        }
        public override string ToString() {
            return $"{Title}—{Cost}";
        }
    }
}
