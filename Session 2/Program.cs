// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

int i = 0;
int age = 83;
string name = "Chris";
bool internationalStudent= false;
Console.WriteLine("Hello, my name is "
    + name);

i = 50;
switch(i)
{
    case 50:
    case 60:
        Console.WriteLine("I take it back");
        break;
    default:
        Console.WriteLine("No match");
        break;
}