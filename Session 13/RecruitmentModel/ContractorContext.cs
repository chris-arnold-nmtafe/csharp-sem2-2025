using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace RecruitmentModel {
    /// <summary>
    /// 
    /// </summary>
    public class ContractorContext : DbContext
    {
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL("server=localhost;database=ef_test;user=root;password=");
        }
    }
}
