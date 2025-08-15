namespace TopLevelExample
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            for (int i = 4; i < 5; i++)
            {
                int num1 = 2;
                int temp = (num1 ^ i) / i!;
                Console.WriteLine(temp);
            }
        }
    }
}
