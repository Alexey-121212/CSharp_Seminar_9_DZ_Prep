// Выводим рекурсивным методом натуральные числа от M до N

Console.Clear();
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
if (m<1) return;

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
if (n<1) return;

PrintSum(m,n);

// Methods

static void PrintSum(int mi, int ni)
{
    if (mi>=ni)
    {
        PrintSum(mi - 1, ni);
        Console.WriteLine(mi);
    }
}
