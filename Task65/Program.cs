// Программа выводить все числа от M до N

Console.Write($"Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NumberFromMtoN (numberM, numberN);

void NumberFromMtoN (int m, int n)
{
    if (m < n)
    {
        
        Console.Write($"{m} ");
        NumberFromMtoN(m + 1, n);
        
    }
    else if (n < m)
    {
        
        Console.Write($"{m} ");
        NumberFromMtoN(m - 1, n);
    }
    else
    {
        Console.Write($"{m}");
    }
}