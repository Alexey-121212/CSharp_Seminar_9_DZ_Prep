// Найти индекс первого элемента трех последовательных с максимальной суммой

Console.Clear();

// int[] massiv = CreateFillPrintRndIntArray(30);
int[] massiv = { 4, 6, 1, 4, 7, 9, 2, 4, 6, 1 };

ArrayCreator.PrintRndIntArray(massiv,0);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(ArrayCreator.FindThreeMax(massiv));

// int startMaxThreeIndex = ArrayCreator.FindThreeMax(massiv);

// Console.WriteLine();
// Console.WriteLine(startMaxThreeIndex);

