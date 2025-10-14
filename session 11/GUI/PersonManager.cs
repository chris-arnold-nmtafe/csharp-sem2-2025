using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    /// <summary>
    /// This Person Manager class manages my people.
    /// It can add, remove and return all of the people.
    /// </summary>
    class PersonManager
    {
        List<Person> people = new List<Person>();

        /// <summary>
        /// This class manages all of the people domain objects.
        /// </summary>
        /// <param name="numOfPeople">the number of people to permit in the system</param>
        public PersonManager(int numOfPeople)
        {
            people.Add(new Person(0, "Egg", "Gus", new DateTime(2005, 04, 05), 170));
            people.Add(new Person(1, "Betty", "White", new DateTime(1920, 01, 25), 158));
        }

        public List<Person> GetPeople()
        {
            return people.ToList();
        }

        public void Add(Person newPerson)
        {
            people.Add(newPerson);
        }

        public void Remove(Person oldPerson)
        {
            people.Remove(oldPerson);
        }

        public Person Search(int id)
        {
            return people.Find(x=>x.ID==id);
        }

        public Person Search(string name)
        {
            return people.Find(x=>x.FirstName.Contains(name) || x.LastName.Contains(name));
        }

        public List<Person> Search(DateTime start, DateTime end)
        {
            //Predicate<Person> isBornBetween = (person) => { 
            //    return person.DateOfBirth >= start && person.DateOfBirth <= end;
            //};
            return people.FindAll(x => x.DateOfBirth >= start && x.DateOfBirth <= end);
            List<Person> results = new List<Person>();
            //results = people.FindAll(isBornBetween);
            for (int i = 0; i < people.Count; ++i) {
                if (people[i].DateOfBirth >= start && people[i].DateOfBirth <= end) {
                    results.Add(people[i]);
                }
            }
            return results;
        }


    }
}
