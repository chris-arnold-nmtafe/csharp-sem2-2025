using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace GUI
{
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }

        public Person()
        {
        }

        public Person(int id, string firstName, string lastName, DateTime dateOfBirth, double height)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Height = height;
        }

        public Person Clone() {
            Person person = new Person() {
                ID = this.ID,
                FirstName = this.FirstName,
                LastName = this.LastName,
                DateOfBirth = this.DateOfBirth,
                Height = this.Height
            };
            return person;
        }

        /// <summary>
        /// Calculates the age from the date of birth
        /// </summary>
        /// <returns>Current Age</returns>
        public int Age()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"[{ID}] {FirstName} {LastName} ({DateOfBirth.Year})";
        }

    }
}
