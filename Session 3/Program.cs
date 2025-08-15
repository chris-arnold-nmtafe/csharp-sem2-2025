// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

for (int i = 4; i < 5; i++)
{
    int num1 = 2;
    int temp = (num1 ^ i) / i!;
    Console.WriteLine(temp);
}
return;

// Bookmark: Session 2 recap on ifs.
// Experiment: can be break from an if?
//string response=Console.ReadLine();
//switch (response) {
//    case "yay":
//        if (response == "yay") {
//            Console.WriteLine("happie");
//            break;
//        } else {
//            Console.WriteLine("oh noes");
//        }
//        Console.WriteLine("great");
//        break;
//    default:
//        Console.WriteLine("sad.");
//        break;
//}

//int c = 0;
//while (c < 3)
//{
//    Console.WriteLine(++c);
//}
//Console.WriteLine("Finished!");
string[] numbers = new string[3] { "one", "1", "is tooooo" };
foreach (string thingToPrint in numbers)
{
    Console.WriteLine(thingToPrint);
    break;
}
//Bookmark For loop
//Console.WriteLine("Finished! Bookmark For loop");
//void writeMessage(string message)
//{
//    Console.WriteLine(message);
//}
//writeMessage("1!"); writeMessage("2!"); writeMessage("3!");
////for (/*initial setup*/;/*condition to evalute*/;/*action at end of loop*/)
//for (
//    int i=0;
//    i<numbers.Length;
//    ++i
//) 
//{
//    Console.WriteLine(numbers[i]);
//}
//Console.WriteLine("Finished!");
//Everything. I mean EVARYTHING in C# is object
object o = new object();
string stringVal = o.ToString(); //And so EVARYTHING can be represented as a string

string value="string value".ToString();
string stringstringstring=value.ToString();

Console.Write("Give ");
Console.Write("me a number? ");
string input=Console.ReadLine();

//Raises errors, like Convert.ToInt32()
//int parsedNum=int.Parse(input);

int number;
bool parsedOK = int.TryParse(input, out number);
if (!parsedOK)
{
    Console.WriteLine("You aint no good");
    return;
}

try
{
    //Error prone: the try catch will soak up runtime errors.
    //A little tricky to manage your variable state.
    int num = Convert.ToInt32(input);
} 
catch (ArgumentException ex)
{
    Console.WriteLine(ex);
}

//double result = 12.5f + 12.5d;

//bool convertedOK=int.TryParse(input,out inputInt);
//if (convertedOK)
//int[] inputs=new int[3];

//for (int index = 0; index < inputs.Length; ++index)
//{
//    string input = Console.ReadLine();
//    int inputInt;
//    if (int.TryParse(input, out inputInt))
//    {
//        inputs[index] = inputInt;
//    } else
//    {
//        --index;
//    }
//}
//Console.WriteLine("Finished!");
//float decimalNumber = 1.75f;
//int integer = (int)decimalNumber;
//Console.WriteLine(integer);