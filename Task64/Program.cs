// РЕКУРСИЯ Программа принимает на вход число N и выводит все натуральные числа 
// в промежутке от N до 1

Console.Write($"Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersFrom1toN (number);


void NumbersFrom1toN (int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    NumbersFrom1toN(n - 1); // числа в обратном порядке складываются в стек
    
}