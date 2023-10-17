// Выводим возводим M в степень N рекурсией

Console.Clear();
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
if (m<1) return;

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
if (n<1) return;

Console.WriteLine("M in N degree: "+CalcMInNDegree(m,n));

// Methods

static int CalcMInNDegree(int mi, int ni)
{
    if (ni>=1)
    {
        return mi*CalcMInNDegree(mi,ni-1);
    }
    else
    return 1;
}
