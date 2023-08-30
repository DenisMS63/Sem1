// Программа принимает на вход число и сообщается количество цифр в числе

int AmountOfNumbers(int n)
{
    if (n == 0) return 1;

    int count = 0;
    while (n != 0)
    {
        n /= 10;
        count++;
    }
    return count;

}

Console.WriteLine($"Введите длинное число");
int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{input} -> {AmountOfNumbers(input)}");