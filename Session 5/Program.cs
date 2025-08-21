// See https://aka.ms/new-console-template for more information

using TAFE.Trigonometry;
using Microsoft.Extensions.Configuration;

Square square = new Square(3);
int area = square.getArea();
Console.WriteLine($"The square's area is {area}.");
Console.WriteLine($"Half the square's area is {square.getArea(true)}.");

Circle circle = new Circle(5, 5, 10);
Circle circle2 = new Circle(2, 8, 5);
Console.WriteLine($"This circle is at {circle.X}, {circle.Y}");
Console.WriteLine($"This circle has area {circle.GetArea()}");
//circle.MoveTo(9, 10);
Console.WriteLine($"This circle is at {circle2.X}, {circle2.Y}");
Console.WriteLine($"This circle has area {circle2.GetArea()}");


Console.WriteLine("Hello, World!");



int numbersToDraw = 6;

int[] selectedNumbers = new int[numbersToDraw];
for (int i = 0; i<selectedNumbers.Length;++i)
{
    selectedNumbers[i] = i;
}

// Build a configuration object from command line
IConfiguration config = new ConfigurationBuilder()
    .AddCommandLine(args)
    .Build();

// Read configuration values
Console.WriteLine($"InputPath: {config["InputPath"]}");
Console.WriteLine($"OutputPath: {config["OutputPath"]}");

