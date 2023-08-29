// Программа принимает на вход число N 
// и отображает таблицу квадратов чисел от 1 до N

Console.WriteLine($"Введите число N");
int NN = Convert.ToInt32(Console.ReadLine());

void TableOfSquares (int N, int x)
{
    Console.WriteLine($"Таблица квадратов чисел от 1 до N:");
    for (int i = 1; i <= N; i++)
    {
        double square = Math.Pow(i, x);
        Console.WriteLine($"{i} -> {square}");
    }
}

TableOfSquares (NN, 2);