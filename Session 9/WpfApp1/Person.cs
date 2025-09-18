using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1 {
    internal class Person {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public override string ToString() {
            return $"{FamilyName} {GivenName}";
        }
    }
}
