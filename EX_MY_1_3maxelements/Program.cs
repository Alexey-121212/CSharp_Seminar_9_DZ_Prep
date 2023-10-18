// Найти индекс первого элемента трех последовательных с максимальной суммой


Console.Clear();

int[] massiv = CreateFillPrintRndIntArray(30);
int startMaxThreeIndex = FindThreeMax(massiv);

Console.WriteLine();
Console.WriteLine(startMaxThreeIndex);

//Methods

int FindThreeMax(int[] mass)
{
    int maxIndex = 0;
    int maxValue = 0;
    for (int i = 0; i < mass.GetLength(0)-2; i++)
    {
        if ((mass[i] + mass[i + 1] + mass[i + 2]) > maxValue)
        {
            Console.Write(mass[i]+"  ");
            maxValue = mass[i] + mass[i + 1] + mass[i + 2];
            maxIndex = i;
        }
    }
    return maxIndex;
}

static int[] CreateFillPrintRndIntArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}
