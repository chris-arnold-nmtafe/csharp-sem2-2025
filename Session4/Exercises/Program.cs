namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "one", "two", "three" };
            string[] filtered=Array.FindAll(numbers,
                x=>x.EndsWith('e'));

            foreach (string s in filtered)
            {
                Console.WriteLine(s);
            }
        }
        static int subtract(int x, int y) {
            return x - y;
        }
        static int add(int x, int y) {
            return x + y;
        }
        static void WelcomeMessage(string name="Fool!")
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Hi, {name}!");
            Console.WriteLine("-----------------");
        }
    }
}
