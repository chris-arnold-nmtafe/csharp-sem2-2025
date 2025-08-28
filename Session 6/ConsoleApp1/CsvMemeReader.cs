using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInheritance
{
    public class CsvMemeReader : AbstractMemeFileReader
    {
        public CsvMemeReader(string filePath) : base(filePath) {}
        public override string EncodeMemes(List<Meme> memes)
        {
            string encodedMemes = "";
            foreach (Meme meme in memes)
            {
                encodedMemes += $"{meme.ID},{meme.Name},{meme.Description}\n";
            }
            return encodedMemes;
        }

        public override List<Meme> DecodeMemes(string encodedMemes)
        {
            List<Meme> results = new List<Meme>();
            string[] lines = encodedMemes.Split('\n');
            foreach (string line in lines)
            {
                string[] items = line.Split(",");
                if (items.Length == 3)
                {
                    Meme nextMeme = new Meme(int.Parse(items[0]), items[1], items[2]);
                    results.Add(nextMeme);
                }
            }
            //decode
            return results;
        }
    }
}
