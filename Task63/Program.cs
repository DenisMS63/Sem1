// РЕКУРСИЯ
// Программа выводит все значения от 1 до N

Console.Write($"Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersFrom1toN (number);


void NumbersFrom1toN (int n)
{
    if (n == 0) return;
    NumbersFrom1toN(n - 1); // числа в обратном порядке
    Console.Write($"{n} ");
}