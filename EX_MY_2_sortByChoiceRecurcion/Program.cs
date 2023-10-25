// Сортировка массива выбором с использованием рекурсии




using static ArrayCreator;

int length = 10;
int[] massiv = CreateFillRndIntArray(length);

Clear();


Console.Clear();
PrintRndIntArray(massiv, 0);
Console.WriteLine();
Console.WriteLine();

SortArrayChoice(massiv, 5);
PrintRndIntArray(massiv, 0);









