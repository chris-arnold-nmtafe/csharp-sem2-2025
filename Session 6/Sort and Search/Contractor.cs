using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_and_Search
{
    internal class Contractor
    {
        public Contractor(string name) {
            this.Name = name;
        }
        public string Name { get; private set; }
    }

    class Job
    {
        public Job() { }
        public Contractor AssignedContractor { get; private set; }
        public bool Assigned { get { return AssignedContractor != null; } }
    }
}
