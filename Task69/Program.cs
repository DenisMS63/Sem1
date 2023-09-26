// РЕКУРСИЯ программа принимает на вход два числа А и В и возводит числа А
// в натуральную степень В

Console.Write($"Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int AtoThePowerOfB (int numA, int numB)
{
    if (numB == 0) return 1;    
    return numA * AtoThePowerOfB (numA, numB - 1);
}

int atoThePowerOfB = AtoThePowerOfB(a, b);
Console.Write($"Число А в степени В -> {atoThePowerOfB}");