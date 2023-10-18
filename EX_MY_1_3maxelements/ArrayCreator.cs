
public static class ArrayCreator
{
    public static int FindThreeMax(int[] mass)
    {
        int maxIndex = 0;
        int maxValue = 0;
        for (int i = 0; i < mass.GetLength(0) - 2; i++)
        {
            if ((mass[i] + mass[i + 1] + mass[i + 2]) > maxValue)
            {
                maxValue = mass[i] + mass[i + 1] + mass[i + 2];
                maxIndex = i;
            }
        }
        return maxIndex;
    }



    public static int[] CreateFillRndIntArray(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = new Random().Next(100);
            Console.Write($"{arr[i]} ");
        }
        return arr;
    }

    public static void PrintRndIntArray(int[] arr, int startElement)
    {
        if (startElement < arr.GetLength(0))
        {
            Console.Write($"{arr[startElement]}\t");
            PrintRndIntArray(arr, startElement + 1);
        }
    }

}