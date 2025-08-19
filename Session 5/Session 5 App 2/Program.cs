// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

int drawSize = 6;
int minNumber = 1;
int maxNumber = 45;

int[] userNumbers = new int[6]
{0,1,2,3,4,5};
int[] randomNumbers = new int[drawSize];
string[] strings = { "One", "two", "3" };
//Console.WriteLine(strings[0]);
strings[2] = "Three";

for (int i = 0; i < userNumbers.Length; ++i)
{
    //Console.WriteLine(userNumbers[i]);
    //    Console.WriteLine(strings[i]);
}
foreach (int number in userNumbers)
{
    //Console.WriteLine(number);
}


List<int> numberList = new List<int>() { 1, 2, 3 };
Dictionary<string, DateTime> dates =
    new Dictionary<string, DateTime>()
    {
        { "now",DateTime.Now },
        { "then", new DateTime(2000,1,1) },
        { "soon", new DateTime(2026,1,1) },
    };
Console.WriteLine(dates["then"]);


for (int i = numberList.Count - 1; i >= 0; --i)
{
    numberList.RemoveAt(i);
};
Console.WriteLine(numberList.Count);
foreach (int number in numberList)
{
    numberList.Remove(number);
    Console.WriteLine(number);
}

//Resize examples
int[] intArray = { 1, 2, 3, 4 };
List<int> intList = new List<int>() { 1, 2, 3, 4 };
//Append a 5 to a list
intList.Add(5);
//Append a 5 to the array
int[] temp = new int[intArray.Length + 1];
Array.Copy(intArray, 0, temp, 0, intArray.Length);
temp[4] = 5;
intArray = temp;
//Exercise 2
string[] names = new string[8] { "Oosman", "Oosman", "Oosman", "Oosman", "Oosman", "Oosman", "Oosman", "Oosman" };
int[] grades = new int[9] { 100, 100, 100, 100, 100, 100, 100, 100, 100 };
if (grades.Length != names.Length)
{
    Console.WriteLine("FAIL!");
}
else
{
}

for (int i = 0;
    i < Math.Min(grades.Length, names.Length);
    i++)
{
    Console.WriteLine(
        $"{names[i]}'s grade is {grades[i]}"
    );
}
