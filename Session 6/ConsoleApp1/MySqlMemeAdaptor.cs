using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInheritance
{
    public class MySqlMemeAdaptor : IMemeReader
    {
        public string ConnectionString { get; private set; }
        public MySqlMemeAdaptor(string connectionString) {
            ConnectionString = connectionString;
        }

        public List<Meme> LoadMemes()
        {
            throw new NotImplementedException();
        }

        public void SaveMemes(List<Meme> memes)
        {
            throw new NotImplementedException();
        }
    }
}
