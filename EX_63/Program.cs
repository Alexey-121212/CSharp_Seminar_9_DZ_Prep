// Находим рекурсивным методом сумм чисел от 1 N

Console.Clear();

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalcSum(n));

// Methods

static int CalcSum(int n)
{
    if (n>0)
    {
        return n+CalcSum(n - 1);
    }
    else
    {
        return 0;
    }
}
