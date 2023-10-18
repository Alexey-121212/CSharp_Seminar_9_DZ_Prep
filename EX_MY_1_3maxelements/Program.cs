// Найти индекс первого элемента трех последовательных с максимальной суммой

using static ArrayCreator;
using System.Diagnostics;

Console.Clear();

int[] massiv = CreateFillRndIntArray(10000000);
//int[] massiv = { 9, 2, 7, 9, 4 };

Stopwatch sw = new Stopwatch();

// PrintRndIntArray(massiv, 0);
sw.Start();
Console.WriteLine("\t" + FindThreeMax(massiv));
sw.Stop();
Console.WriteLine("   " + sw.ElapsedMilliseconds);
sw.Reset();

// PrintRndIntArray(massiv, 0);
sw.Start();
Console.WriteLine("\t" + NewFindThreeMax(massiv));
sw.Stop();
Console.WriteLine("   " + sw.ElapsedMilliseconds);



// int startMaxThreeIndex = ArrayCreator.FindThreeMax(massiv);

// Console.WriteLine();
// Console.WriteLine(startMaxThreeIndex);

