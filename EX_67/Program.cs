// Находим рекурсивным методом сумму цифр числа N

Console.Clear();

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine("Не то число, введите заново");
    return;
}

Console.WriteLine(CalcDigSum(n));

// Methods

static int CalcDigSum(int n)
{
    if (n > 0)
    {

        return n % 10 + CalcDigSum(n / 10);
    }
    else
    {
        return 0;
    }
}
