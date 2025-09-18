using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInheritance
{
    public interface IMemeReader
    {
        public void SaveMemes(List<Meme> memes);
        public List<Meme> LoadMemes();
    }

    public static class MemeStorageFactory {
        public static IMemeReader CreateMemeReader(string type,string configuration)
        {
            switch (type)
            {
                case "csv":
                    return new CsvMemeReader(configuration);
                case "json":
                    return new JsonMemeReader(configuration);
                case "mysql":
                    return new MySqlMemeAdaptor(configuration);
                default:
                    throw new ArgumentException("meaningful error message.");
            }
        }
    }

}
