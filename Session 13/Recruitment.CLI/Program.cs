using Microsoft.EntityFrameworkCore.Storage;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using RecruitmentModel;

namespace Recruitment.CLI {
    internal class Program {
        static void Main(string[] args) {
            using (ContractorContext ctxt = new ContractorContext()) {
                try {
                    ctxt.Database.EnsureCreated();
                } catch (MySqlException theError) {
                    Console.WriteLine(theError.Message);
                    Console.WriteLine("The database appears to be offline. Maybe? Try again after restarting it.");
                    //Environment.Exit(0);
                    return;
                } catch (AccessViolationException ave) {
                    Console.WriteLine("This database user does not have adequate permissions to create a database");
                    Console.WriteLine(ave.Message);
                    return;
                } catch (Exception ex) {
                    Console.WriteLine("Something happened!");
                } finally {
                    Console.WriteLine("Finally!");
                }

                using (IDbContextTransaction tx = ctxt.Database.BeginTransaction()) {
                    Job banana = ctxt.Find<Job>(2)!;
                    //Job job = new Job() {
                    //    Title = "Eat Banana",
                    //    Cost = 63000000,
                    //    Date = new DateTime(2024, 1, 1),
                    //    Completed = true
                    //};
                    //ctxt.Jobs.Add(job);
                    banana.Completed = false;
                    ctxt.SaveChanges();

                    //Console.WriteLine("This is all worth " + (job.Cost / 0));
                    //throw new ApplicationException("Task failed successfully.");

                    tx.Commit();
                }
/*
                Contractor contractor = new Contractor() {
                    Name = "R. Mutt",
                    Skillset = "Plumber",
                    DateStarted = new DateTime(1900,1,1),
                    HourlyRate = 100
                };
                ctxt.Add(contractor);
                Job job = new Job() {
                    Title = "Install Urinal",
                    Completed = false,
                    Date = new DateTime(1917, 4, 9),
                    Cost = 100000
                };
                ctxt.Add(job);
                ctxt.SaveChanges();
*/
            }
        }
    }
}
