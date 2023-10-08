// РЕКУРСИЯ Программа для вычисления функции Акермана, даны два 
// неотрицательных числа M и N

int AckermanFunction (int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AckermanFunction (n - 1, 1); 
    else return AckermanFunction (n - 1, AckermanFunction (n, m - 1));
}

Console.Write($"Введите целое неотрицательное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите целое неотрицательное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

int ackermanFunction = AckermanFunction (numberN, numberM);
Console.Write($"Результат вычисления функции Акермана -> {ackermanFunction}");