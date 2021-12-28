int[] PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return array;
}

int[] CreateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int[] ourArray = PrintArray(CreateArray(7, 1, 10));
Console.WriteLine();

void EvenNumbers(int[] ourArray)
{
    for (int i = 0; i < ourArray.Length; i++)
    {
        if (ourArray[i] % 2 == 0)
        {
            Console.Write($"{ourArray[i]} ");
        }
    }
}
EvenNumbers(ourArray);
