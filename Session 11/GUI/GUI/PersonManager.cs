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
    class PersonManager {
        List<Person> people = new List<Person>();

        public PersonManager(int numOfPeople) {
            people.Add(new Person(0, "Egg", "Gus", new DateTime(2005, 04, 05), 170));
            people.Add(new Person(1, "Betty", "White", new DateTime(1920, 01, 25), 158));
        }

        public List<Person> GetPeople() {
//            return people.ToList();
            List<Person> forView = new List<Person>();
            foreach (Person person in people) {
                forView.Add(person.Clone());
            }
            return forView;
        }

        public void Add(Person newPerson) {
            people.Add(newPerson);
        }

        public void Remove(Person oldPerson) {
            int index = people.FindIndex(x=>oldPerson.ID == x.ID);
            if (index >= 0) {
                people.RemoveAt(index);
            }
        }

        public void EditPerson(Person changes) {
            int index = people.FindIndex(x => changes.ID == x.ID);
            if (index >= 0) {
                people[index].Height = changes.Height;
                people[index].LastName = changes.LastName;
                people[index].FirstName = changes.FirstName;
                people[index].DateOfBirth = changes.DateOfBirth;
            }
        }

        public Person Search(int id) {
            for (int i = 0; i < people.Count; ++i) {
                if (people[id].ID == id) {
                    return people[id];
                }
            }
            return null;
        }

        public List<Person> Search(string name) {
            return people.FindAll((x) => { return x.ToString().Contains(name); });
        }

        public List<Person> Search(DateTime start, DateTime end) {
            List<Person> results = new List<Person>();
            //TODO: do stuff
            return results;
        }


    }
}
