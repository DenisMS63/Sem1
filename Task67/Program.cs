// РЕКУРСИЯ программа принимает на вход число и отображает сумму цифр из
// которых оно состоит

int SumOfDigits (int num) // 453 -> 45 -> 4 -> 0
{
    if (num == 0) return 0;
    return num % 10 + SumOfDigits (num / 10); // СТЭК: 453 -> 45 -> 4
    // 4 % 10 + 45 % 10 + 453 % 10 = 4 + 5 + 3 + 0 (из return) = 12 
}

Console.Write($"Введите, как минимум, трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfDigits = SumOfDigits (number);
Console.WriteLine($"Сумма цифр числа -> {sumOfDigits}");