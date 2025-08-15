// See https://aka.ms/new-console-template for more information

//pattern to the sequence that I'm generating (even numbers):
for (int i=0;i<10;i+=2)
{
    //Console.WriteLine(GetArea(i,i));
}

//No pattern
//Console.WriteLine(GetArea(2, 5));
//Console.WriteLine(GetArea(38, 245));

int ____width = 10;
int ____height = 70;
Console.WriteLine(GetArea(____width, ____height));
int GetArea(int width, int height)
{
    return width * height;
}

//How to invoke with an out parameter
double result;
GetCircleArea(10,out result);
Console.WriteLine(result);

//How to invoke with a return value
Console.WriteLine(GetCircleArea1(10));

//How to invoke with a ref parameter
double result2 = 3;
GetCircleArea2(10,ref result2);
Console.WriteLine(result2);

void GetCircleArea(double radius,out double result)
{
    result=Math.Pow(radius,2) * Math.PI;
}
double GetCircleArea1(double radius)
{
    return Math.Pow(radius, 2) * Math.PI;
}
void GetCircleArea2(double radius,ref double result)
{
    Console.WriteLine(result);
    result = Math.Pow(radius, 2) * Math.PI;
}

PrintSomeThings();
void PrintSomeThings()
{
    //Console.WriteLine("The first thing");
    //Console.WriteLine("The second thing");
}