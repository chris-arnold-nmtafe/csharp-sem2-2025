using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1 {
    class Person {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }

        public Person() {
        }

        public Person(int id, string firstName, string lastName, DateTime dateOfBirth, double height) {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Height = height;
        }



        /// <summary>
        /// Calculates the age from the date of birth
        /// </summary>
        /// <returns>Current Age</returns>
        public int Age() {
            return 0;
        }

        public override string ToString() {
            return $"[{ID}] {FirstName} {LastName} ({DateOfBirth.Year})";
        }
    }

}