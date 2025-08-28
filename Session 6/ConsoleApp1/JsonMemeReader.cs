using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOInheritance
{
    public class JsonMemeReader : AbstractMemeFileReader
    {
        public JsonMemeReader(string filename) : base(filename) { }
        public override List<Meme> DecodeMemes(string encodedMemes)
        {
            return JsonConvert.DeserializeObject<List<Meme>>(encodedMemes);
        }

        public override string EncodeMemes(List<Meme> memes)
        {
            return JsonConvert.SerializeObject(memes);
        }
    }
}
