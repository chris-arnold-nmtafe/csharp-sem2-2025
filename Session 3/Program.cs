// See https://aka.ms/new-console-template for more information

using System;

int i = 0;
while (i<3)
{
    Console.WriteLine(i);
    ++i;
}
Console.WriteLine("Finished!");
int[] numbers=new int[3] { 0,1,2 };
foreach(int index in numbers)
{
    Console.WriteLine(index);
}
Console.WriteLine("Finished!");
for (
    int y=0;
    y<3;
    ++y)
{
    Console.WriteLine(y);
}
Console.WriteLine("Finished!");

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
Console.WriteLine("Finished!");
float decimalNumber = 1.75f;
int integer = (int)decimalNumber;
Console.WriteLine(integer);