using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInheritance
{
    public class Meme
    {
        public Meme(int id,string name,string description) {
            ID= id;
            Name= name;
            Description= description;
        }
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public byte[] ImageData { get; private set; }
        public override string ToString() {
            return $"[{ID}] {Name}: {Description}";
        }
    }

}
