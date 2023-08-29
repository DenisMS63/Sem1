// Программа принимает на вход число А и отображает сумму чисел
// от 1 до А

int SumOfNums(int x)
{
    int sum = 0;
    for (int i = 1; i <= x; i++)
    {
        checked
        {
            sum += i;
        }

    }
    return sum;
}

Console.WriteLine($"Введите число А");
int input = Convert.ToInt32(Console.ReadLine());

if (input == 0) Console.WriteLine($"Число А не должно быть равно нулю");
else if (input < 0) Console.WriteLine($"Число А не может быть отрицательным");
else
{
    Console.WriteLine($"Сумма чисел от 1 до А");
    Console.WriteLine($"{input} -> {SumOfNums(input)}");
}

