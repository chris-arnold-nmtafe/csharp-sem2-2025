namespace OOInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meme meme1 = new Meme(0,"Chuck Norris","Chuck Norris caught all the Pokemons. On a landline.");
            Meme meme2 = new Meme(1, "WDA", "Web Development Acronyms");
            Meme meme3 = new Meme(2, "Correct Horse Battery Staple", "XKCD cartoon on password strength");
            Meme meme4 = new Meme(3, "Double Spiderman", "I am a dog mum so.....");

            IMemeReader csvMemeReader = new JsonMemeReader("memes.json"); //new CsvMemeReader("memes.csv");
            List<Meme> memes = new List<Meme>() { meme1, meme2, meme3, meme4 };
            csvMemeReader.SaveMemes(memes);
            
            List<Meme> reconstitutedMemes = csvMemeReader.LoadMemes();
            Console.WriteLine(reconstitutedMemes.Count);


            //Transcoding example:
            //IMemeReader csvMemeReader = new CsvMemeReader("memes.csv");
            //List<Meme> reconstitutedMemes = csvMemeReader.LoadMemes();
            //Console.WriteLine(reconstitutedMemes.Count);

            //IMemeReader jsonMemeWriter = new JsonMemeReader("memes2.json");
            //jsonMemeWriter.SaveMemes(reconstitutedMemes);
        }
    }
}
