// Программа принимает на вход число и отображает сумму 
// цифр из которых состоит введеное число

int SumOfDigits(int n)
{
    int sum = 0;

    if (n < 0)
    {
        n *= -1;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    else
    {
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
    }
    return sum;
}

Console.Write($"Введите длинное число: ");
int input = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма всех цифр числа {input} = {SumOfDigits(input)}");