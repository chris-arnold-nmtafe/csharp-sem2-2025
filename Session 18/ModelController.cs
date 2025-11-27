using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Session_18
{
    public class Thing
    {
        public ulong ID { get; set; }
        public string Name { get; set; }
        public DateTime ThingDate { get; set; }
        public bool IsBoyOr8Ball { get; set; }

        public override string ToString() {
            return Name;
        }
    }

    public class Controller {
        const string conString = "database=thingos;server=localhost;user=root;password=";
        //        notorious_rbg BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
        //thing_name VARCHAR(20) NOT NULL,
        //date_of_thing DATETIME,
        //	inventor BIGINT UNSIGNED,
        //	boy_or_8ball BOOL
        const string insert = @"INSERT INTO things (thing_name,date_of_thing,boy_or_8ball)
VALUES (@thing_name,@date_of_thing,@boy_or_8ball);
SELECT LAST_INSERT_ID();";
        const string delete = "DELETE FROM things WHERE notorious_rbg=@id";
        /// <summary>
        /// Get off my lawn!
        /// </summary>
        public List<Thing> Thinsg { get; private set; }
        public Controller() {
            Thinsg = new List<Thing>();
        }
        public void AddThing(Thing thing) {
            using MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            using MySqlCommand cmd = new MySqlCommand(insert, con);
            //MessageBox.Show(cmd.CommandText);
            cmd.Parameters.AddWithValue("@thing_name", thing.Name);
            cmd.Parameters.AddWithValue("@date_of_thing", thing.ThingDate);
            cmd.Parameters.AddWithValue("@boy_or_8ball", thing.IsBoyOr8Ball);
            ulong newKey = (ulong)cmd.ExecuteScalar();
            thing.ID = newKey;
            Thinsg.Add(thing);
        }
        public void RemoveThing(Thing thing) {
            using MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            using MySqlCommand cmd = new MySqlCommand(delete, con);
            cmd.Parameters.AddWithValue("@id", thing.ID);
            cmd.ExecuteNonQuery();
            Thinsg.Remove(thing);
        }
    }
}
