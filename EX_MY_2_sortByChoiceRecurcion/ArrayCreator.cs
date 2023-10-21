/// <summary>
/// Класс работы с массивом
/// </summary>
public static class ArrayCreator
{
    public static int FindThreeMax(int[] mass)
    {
        int maxValue = 0;
        for (int i = 0; i < mass.GetLength(0) - 2; i++)
        {
            if ((mass[i] + mass[i + 1] + mass[i + 2]) > maxValue)
            {
                maxValue = mass[i] + mass[i + 1] + mass[i + 2];
            }
        }
        return maxValue;
    }
    public static int NewFindThreeMax(int[] mass)
    {


        int triplet = mass[0] + mass[1] + mass[2];
        int maxValue = triplet;

        for (int i = 1; i < mass.GetLength(0) - 2; i++)
        {
            if ((triplet - mass[i - 1] + mass[i + 2]) > maxValue)
            {
                maxValue = mass[i] + mass[i + 1] + mass[i + 2];

            }
            triplet = triplet - mass[i - 1] + mass[i + 2];
        }
        return maxValue;
    }
    /// <summary>
    /// Создает, заполняет массив случайными целыми числами от 0 до 100
    /// </summary>
    /// <param name="length">Длина массива</param>
    /// <returns>Возвращает массив</returns>
    public static int[] CreateFillRndIntArray(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = new Random().Next(10);
        }
        return arr;
    }
    /// <summary>
    /// Печатает массив
    /// </summary>
    /// <param name="arr">массив</param>
    /// <param name="startElement">элемент с которого распечатывать</param>
    public static void PrintRndIntArray(int[] arr, int startElement)
    {
        if (startElement < arr.GetLength(0))
        {
            Console.Write($"{arr[startElement]}\t");
            PrintRndIntArray(arr, startElement + 1);
        }
    }

    public static void SortArrayChoice(int[] unsortedArr, int startElement = 0)
    {
        int workElement = startElement;
        int temp;
        while (workElement < unsortedArr.GetLength(0) - 1)
        {
            for (int i = workElement+1; i < unsortedArr.GetLength(0); i++)
            {
                if (unsortedArr[i] < unsortedArr[workElement])
                {
                    temp = unsortedArr[workElement];
                    unsortedArr[workElement] = unsortedArr[i];
                    unsortedArr[i] = temp;
                }
            }
            workElement++;
            SortArrayChoice(unsortedArr, workElement);
        }
    }
}