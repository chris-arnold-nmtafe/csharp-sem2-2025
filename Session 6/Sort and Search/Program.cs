// See https://aka.ms/new-console-template for more information
int[] numbers = { 1, 5, 3, 7, 8, 6, 2, 9, 4 };
string[] strings = new string[2];
bool[] bools = new bool[2];

Array.Sort(numbers);
//BubbleSort(numbers);

int indexOf63 = LinearSearch(numbers, 63);
int indexOf11 = LinearSearch(numbers, 11);
int LinearSearch(int[] array, int valueToFind)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == valueToFind)
        {
            return i;
        }
    }
    return -1;
}
Console.WriteLine($"63 is at index {indexOf63}");
Console.WriteLine($"11 is at index {indexOf11}");

void BubbleSort(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        bool swapped = false;
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] >= array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swapped = true;
            }
        }
        if (!swapped) { break; }
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}


int indexof9 = LinearSearchRecursive(numbers,9,0);
int LinearSearchRecursive(int[] array,int valueToFind,int index) {
    if (index >= array.Length)
    {
        return -1;
    }
    if (numbers[index] == valueToFind)
    {
        return index;
    }
    return LinearSearchRecursive(array, valueToFind, index + 1);
}
Console.WriteLine(indexof9);