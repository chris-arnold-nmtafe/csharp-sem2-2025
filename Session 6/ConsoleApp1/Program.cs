using System.Security.Cryptography.X509Certificates;
using OOInheritance.Geometry;

namespace OOInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoCircleThing();
        }
        public static void DoCircleThing()
        {
            Ellipse ellipse = new Ellipse(new Point(), 10, 20);
            Console.WriteLine(ellipse.GetLabelText());
            Console.WriteLine(ellipse.GetArea());
            Ellipse ellipse2 = new Ellipse(new Point(), 10, 10);
            Console.WriteLine(ellipse2.GetLabelText());
            Console.WriteLine(ellipse2.GetArea());
            Circle circle = new Circle(new Point(), 10);
            Console.WriteLine(circle.GetLabelText());
            Console.WriteLine(circle.GetArea());
            DrawThingToScreen(circle);
        }
        private static object screen=new object();
        public static void DrawThingToScreen(DisplayedObject thing)
        {
            thing.drawToScreen(screen);
        }
        public static void DoMemeThing() {
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
