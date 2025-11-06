using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecruitmentModel
{
    [PrimaryKey("Name")]
    public class Contractor
    {
        public string Name { get; set; }
        public string Skillset { get; set; }
        public DateTime DateStarted { get; set; }
        public float HourlyRate { get; set; }
    }
}
