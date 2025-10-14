using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI {
    /// <summary>
    /// This class models a job. We might assign a contractor
    /// </summary>
    public class Job {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double HourlyWage { get; set; }
//        public Contractor AssignedContractor { get; set; }

    }
}
