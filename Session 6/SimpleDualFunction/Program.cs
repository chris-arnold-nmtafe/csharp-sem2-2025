namespace SimpleDualFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "alt")
            {
                new OtherOption().Main(args);
            } else {
                new Program().DoGoNow();
            }
        }

        void DoGoNow()
        {
            Console.WriteLine("Here's a thing!");
        }
    }
}
