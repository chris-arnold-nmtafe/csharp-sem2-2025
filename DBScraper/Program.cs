using MySql.Data.MySqlClient;

namespace DBScraper
{
    internal class Program
    {
        static readonly Dictionary<string, string> typeMap = new Dictionary<string, string>() {
                { "bigint", "long" },
                { "int", "int" },
                { "varchar", "string" },
                { "char", "string" },
                { "timestamp", "DateTime" },
                { "datetime", "DateTime" },
                { "date", "DateTime" },
                { "smallint", "short" },
                { "tinyint", "sbyte" }
            };
        static void Main(string[] args)
        {
            const string getSchemaSQL = "SELECT TABLE_NAME,COLUMN_NAME,DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA=DATABASE() ORDER BY TABLE_NAME;";
            try {
                string conString = args[0];
                using MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                using MySqlCommand command = new MySqlCommand(getSchemaSQL,con);
                MySqlDataReader reader = command.ExecuteReader();
                string lastTable = "";
                while (reader.Read()) {
                    string nextTable = reader.GetString("TABLE_NAME");
                    if (lastTable!= nextTable) {
                        NewTable(nextTable, lastTable == "");
                    }
                    lastTable = nextTable;
                    string colName = reader.GetString("COLUMN_NAME");
                    string type = reader.GetString("DATA_TYPE");
                    Console.WriteLine($"\tpublic {MapCSType(type)} {colName} {{get;set;}}\n"); 
                }
            Console.WriteLine("}");
            } catch {
                    Console.Error.WriteLine("Something went wrong. Is that first argument a good connection string?");
            }
        }
        static void NewTable(string tableName,bool firstTable=false) {
            Console.WriteLine(firstTable?"\n":"}\n\n");
            Console.WriteLine($"public class {tableName}\n{{\n");
        }
        static string MapCSType(string sqltype) {
            string result;
            if (typeMap.TryGetValue(sqltype.ToLower(),out result)) {
                return result;
            }
            Console.Error.WriteLine($"Couldn't map datatype {sqltype}");
            return sqltype + " /* Warns! Couldn't map this data type */ ";
        }
    }
}
