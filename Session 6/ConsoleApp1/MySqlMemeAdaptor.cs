using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOInheritance
{
    public class MySqlMemeAdaptor : IMemeReader
    {
        public string ConnectionString { get; private set; }
        private const string SELECT = "SELECT * FROM memes;";
        private const string INSERT =
@"INSERT INTO memes(name,description) VALUES (@name,@description);
SELECT LAST_INSERT_ID();
";
        private const string UPSERT =
@"
INSERT INTO memes(id,`name`,`description`) 
VALUES (@id,@name,@description)
ON DUPLICATE KEY UPDATE
	`id`=@id,
	`description`=@description;
";
        public MySqlMemeAdaptor(string connectionString) {
            ConnectionString = connectionString;
        }
        public void SaveMemes(List<Meme> memes) {
            using MySqlConnection con =new MySqlConnection(ConnectionString);
            con.Open();
            using MySqlCommand cmd=new MySqlCommand(UPSERT, con);
            cmd.Parameters.AddWithValue("@id", memes[0].ID);
            cmd.Parameters.AddWithValue("@description", memes[0].Description);
            cmd.Parameters.AddWithValue("@name", memes[0].Name);
            cmd.ExecuteNonQuery();
            for (int i = 1; i < memes.Count; i++) {
                cmd.Parameters["@id"].Value = memes[i].ID;
                cmd.Parameters["@description"].Value = memes[i].Description;
                cmd.Parameters["@name"].Value = memes[i].Name;
                cmd.ExecuteNonQuery();
            }
        }
        public List<Meme> LoadMemes() {
            using (MySqlConnection con = new MySqlConnection(ConnectionString)) {
                con.Open();
                using MySqlCommand cmd = new MySqlCommand(SELECT, con);
                using MySqlDataReader reader = cmd.ExecuteReader();
                List<Meme> result = new List<Meme>();
                while (reader.Read()) {
                    int id = Convert.ToInt32(reader["id"]);
                    string name = reader.GetString("name");
                    string description = reader.GetString("description");
                    Meme m = new Meme(id, name, description);
                    result.Add(m);
                }
                return result;
            }
        }
    }
}
