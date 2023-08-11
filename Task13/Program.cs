// Программа принимает на вход число и сообщает третью цифру этого числа
// либо сообщает что третьей цифры нет

Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99 && number < 1000)
{
    int x = number % 10;
    Console.WriteLine($"Третья цифра - {x}");
}
else if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number /= 10;
    }

    int result = number % 10;
    Console.WriteLine($"Третья цифра - {result}");
}

