// See https://aka.ms/new-console-template for more information
class Person
{
    public void Introduction()
    {
        Console.WriteLine("I am a person.");
    }

    public void Introduction(string name)
    {
        Console.WriteLine("My name is " + name);
    }

    public void Introduction(string name, int age = 0)
    {
        Console.WriteLine($"My name is {name} and I am {age} years old.");
    }

}
