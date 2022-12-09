

string[] array = new string[] { "qwerty", "123", "Vi", "Ru", ": )", "asdfg" };

PrintArray(array);
Console.WriteLine();
SOrt(array);
Console.Write("Final: ");
PrintArray(array); 

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void SOrt(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
    }
        else arr[i] = string.Empty;
    }
} 

