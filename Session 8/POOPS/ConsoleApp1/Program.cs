using Geometry;

namespace Programme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            au.edu.wa.nmtafe.geometry.Line line = new au.edu.wa.nmtafe.geometry.Line();
            Rectangle rect = new Rectangle(10,10,21,7);
            Rectangle getRekt = new Rectangle(-1,-1,8,5);
            Rectangle recCentre = new Rectangle(9,3);
            Square squeere = new Square(8);
            Rectangle square = squeere;

            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(getRekt.CalculateArea());

            Console.WriteLine($"position: ({square.X}, {square.Y})");
            Console.WriteLine(square.Y);
            Console.WriteLine(square.CalculateArea());

            Cat cat = new Cat();
            cat.Feed("tuna");
        }
    }
}
