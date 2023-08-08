// Программа принимает на вход трехзначное число 
// и выводит последнюю цифру

Console.WriteLine("Введите любое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num *= -1;

if (num > 99 && num < 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine($"Последняя цифра введеного числа = {lastDigit}");
}
else Console.WriteLine("Введено некорректное число");
