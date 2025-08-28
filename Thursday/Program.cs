//// See https://aka.ms/new-console-template for more information

//int[] list1=new int[4];
//list1[0]=default(int);
//list1[1]=2;
//list1[2]=4;
//list1[3]=8;
//for (int i = 0; i < list1.Length; ++i)
//{
//    Console.WriteLine(list1[i]);
//}
//int[] list2 = new int[4] { default(int), 2, 4, 8 };
//for (int i = 0; i < list2.Length; ++i)
//{
//    Console.WriteLine(list2[i]);
//}
//bool[] temp = new bool[5];
//for (int i = 0; i < temp.Length; ++i)
//{
//    Console.WriteLine(temp[i]);
//}
//string[] dafs = new string[3] { "hay!", "",  default(string) };
//for (int i = 0; i < dafs.Length; ++i)
//{
//    Console.WriteLine(dafs[i]?.Length);
//}
////return;


using System;

string[] catNames = { "Panther", "Mushroom", "Tex", "Scratchie", "Lenny", "Kenny", "Jank", "Lemmy", "Unwieldy" };


//for (int i = 0; i <= catNames.Length; ++i)
//{
//    Console.WriteLine($"wE <3 {catNames[i]}!");
//}
int texIndex = Array.IndexOf(catNames,"Tex");
Console.WriteLine(texIndex);

bool endsWithAY(string value)
{
    return value.EndsWith("y");
}
int ix=Array.FindIndex<string>(catNames, endsWithAY);
Console.WriteLine(ix);

string[] endInYers = Array.FindAll<string>(catNames, endsWithAY);
Console.WriteLine(endInYers.Length + " results found.");

string firstToEndInY=Array.Find(catNames, endsWithAY);
Console.WriteLine(firstToEndInY);

int[] lengths=Array.ConvertAll<string,int>(catNames, x => x.Length);
for (int i = 0; i < lengths.Length; i++)
{
    Console.WriteLine(lengths[i]);
}
//hey, what about finding all of the indexes for everything ending with Y
Console.WriteLine("//hey, what about finding all of the indexes for everything ending with Y");
//While we're at it, let's do a list:
List<int> indices=new List<int>();
int index=Array.FindIndex(catNames, endsWithAY);
while (index >= 0)
{
    indices.Add(index);
    index = Array.FindIndex(catNames, index + 1, endsWithAY);
}
//3 diff ways to read from a list
for (int i = 0; i < indices.Count; i++) { 
    Console.WriteLine(indices[i]);
}
foreach (int i in indices)
{
    Console.WriteLine(i);
}
indices.ForEach(i=>Console.WriteLine(i));


//Difference between args and params
sayHello("Lesson, the Fifth!");
void sayHello(string toWhom)
{
    Console.WriteLine($"Hello, {toWhom}.");
}

//Dictionaries

Dictionary<string,int> ages=new Dictionary<string,int>();
ages["Raf"]=12;
ages["Chris"]=123;
ages["Aquarius"]=2000;

Console.WriteLine("ages dictionary");
Console.WriteLine(ages["Chris"]);
int anAge;
if (!ages.TryGetValue("Cccccc", out anAge))
{
    Console.WriteLine("Didn't find Cccccc in the dictionary");
}

string number = "Cassandra";
if (int.TryParse(number, out _))
{
    Console.WriteLine("Yes! I can parse that");
} else
{
    Console.WriteLine("Yes! I can't parse that");
}

//JSON: Javascript Object Notation
//    "var={'name':'Raf Rafrazi','phone':'000','transport':'scooter'};";

//Linked List:
LinkedList<string> list = new LinkedList<string>();

//Algorithmic Complexity
// O[n]
// O[log(n)]
// O[1]

//SortedList<int> 


//Lottery Application
/*
 * "Using input, ask the user for 5 values and add them to an array. Iterate over the array and find the 
average of the values in the array. (Note: the average is found by adding all numbers together and 
dividing by the number of values there are)"
*/

double[] numericValues = new double[5];
for (int i=0;i<numericValues.Length;i++) { 
    string userInput=Console.ReadLine()!;
    numericValues[i]=double.Parse(userInput);
}
Console.WriteLine("INPUT EXAMPLE");
double total=0;
void addNumber(double num)
{
    total += num;
}
//Array.ForEach(values, addNumber);
Array.ForEach(numericValues, num=>{
    total += num;
//    Console.WriteLine(total);
});
Console.WriteLine($"The average is: {total/numericValues.Length}.");
