// // Программа принимает на вход число N и отображает произведение чисел
// от 1 до N (Факториал)

int Factorial(int x)
{
    int count = 1;
    for (int i = 1; i <= x; i++)
    {
        checked
        { count *= i; }

    }
    return count;
}

Console.Write($"Введите число А: ");
int input = Convert.ToInt32(Console.ReadLine());

if (input == 0) Console.WriteLine($"Число N не должно быть равно нулю");
else if (input < 0) Console.WriteLine($"Число N не может быть отрицательным");
else
{
    Console.WriteLine($"Произведение чисел от 1 до N (Факториал)");
    Console.WriteLine($"{input} -> {Factorial(input)}");
}