// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = { 10, 50, 30, 70, 80, 60, 20, 90, 40, 100 };
//BubbleSort(array);
Array.Sort(array);
//Array.ForEach(array,Console.WriteLine);
//int sixtyPosition = BinarySearch(array, 60);
//Console.WriteLine("Sixty is at " + sixtyPosition);
int recIndex = RecursiveLinearSearch(array, 30, 0);
Console.WriteLine("Thirty is at " + recIndex);
int nfrIndex = RecursiveLinearSearch(array, 25, 0);

//Array.Sort(array);
//Console.WriteLine(array[-1]);
int foundIndex = LinearSearch(array, 25);
if (foundIndex >= 0)
{
    Console.WriteLine("25 is at " + foundIndex);
} else
{
    Console.WriteLine("25 Not found");
}

int LinearSearch(int[] arrayToSearch, int valueToFind)
{
    for (int i = 0; i < arrayToSearch.Length; ++i)
    {
        if (arrayToSearch[i] == valueToFind)
        {
            return i;
        }
    }
    return -1;
}

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        for (int j = 0; j < array.Length-1; ++j)
        {
            if (array[j] > array[j+1])
            {
                int temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
}

int RecursiveLinearSearch(int[] arrayToSearch, int valueToFind, int index)
{
    if (index >= arrayToSearch.Length)
    {
        return -1;
    }
    if (arrayToSearch[index] == valueToFind)
    {
        return index;
    }
    return RecursiveLinearSearch(arrayToSearch, valueToFind, index + 1);
}

