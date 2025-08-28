using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInheritance
{
    //Next time: why interfaces?
    //multiple inheritance: why bad?
    public interface IMemeReader
    {
        public void SaveMemes(List<Meme> memes);
        public List<Meme> LoadMemes();
    }
    public abstract class AbstractMemeFileReader : IMemeReader
    {
        public string FilePath { get; private set; }
        public AbstractMemeFileReader(string filePath)
        {
            FilePath = filePath;
        }
        public void SaveMemes(List<Meme> memes)
        {
            string encodedMemes = EncodeMemes(memes);
            File.WriteAllText(FilePath, encodedMemes);
        }
        public List<Meme> LoadMemes()
        {
            string encodedMemes = File.ReadAllText(FilePath);
            return DecodeMemes(encodedMemes);
        }
        public abstract string EncodeMemes(List<Meme> memes);
        public abstract List<Meme> DecodeMemes(string encodedMemes);
    }
}
