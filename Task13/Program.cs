// Программа принимает на вход число и сообщает третью цифру этого числа
// либо сообщает что третьей цифры нет

Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());

ThirdDigit(number);


void ThirdDigit(int num)
{
    if (num > 99 && num < 1000)
    {
        int x = num % 10;
        Console.WriteLine($"Третья цифра - {x}");
    }
    else if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (num > 999)
        {
            num /= 10;
        }

        int result = num % 10;
        Console.WriteLine($"Третья цифра - {result}");
    }
}

