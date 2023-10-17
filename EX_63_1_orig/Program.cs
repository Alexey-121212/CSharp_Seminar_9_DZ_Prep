// Выводим рекурсивным методом числа от 1 до N


Console.Clear();
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
if (n<1) return;

PrintSum(n);

// Methods

static void PrintSum(int n)
{
    if (n>0)
    {
        PrintSum(n - 1);
        Console.WriteLine(n);
    }
}
