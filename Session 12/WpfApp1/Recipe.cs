using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp1 {
    public class Recipe {
        public string Name { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan TotalTime { get; set; }
        public List<string> Ingredients { get; set; }
        public int PortionSize { get; set; }
        public List<string> Steps { get; set; }
        //public void CookCustardTarts() { 
        //}
        //public void MakePythonMacaroons() { }
    }


    public class Dog : Mammal {
        const int NumberOfLegs = 4;
        public Dog() {
            DigestionTime = new TimeSpan(0, 0, 2);
        }
    }
    public class Mammal : Verterbrate {

    }
    public class Snake : Verterbrate {
        public Snake() {
            DigestionTime = new TimeSpan(184, 0, 0);
        }
    }

    public class Verterbrate {
        public string Name { get; set; }
        private readonly List<object> stomach=new List<object>();
        public List<object> Stomach { get { return stomach.ToList(); } }
        // public List<object> Stomach { get; private set; }
        public DateTime LastFed { get; private set; }
        protected TimeSpan DigestionTime { get;set;}

        public Verterbrate() {
            stomach = new List<object>();
            DigestionTime = TimeSpan.MaxValue;
        }

        public void Feed(object food) {
            stomach.Add(food);
            LastFed = DateTime.Now;
        }
        public bool IsHungry {
            get {
                if (stomach.Count == 0) {
                    return true;
                }
                TimeSpan timeSinceLastFeed = DateTime.Now - LastFed;
                return timeSinceLastFeed > DigestionTime;
            }
        }
        public void ThrowUpOnMumsBed() {
            stomach.Clear();
        }
    }

}
