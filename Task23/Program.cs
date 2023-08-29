// Программа принимает на вход число N и отображает таблицу 
// кубов чисел от 1 до N

Console.WriteLine($"Введите число N");
int inputN = Convert.ToInt32(Console.ReadLine());

void TableOfSquares (int N, int x)
{
    Console.WriteLine($"Таблица квадратов чисел от 1 до N:");
    for (int i = 1; i <= N; i++)
    {
        double square = Math.Pow(i, x);
        Console.WriteLine($"{i, 3} -> {square, 5}");
    }
}

TableOfSquares (inputN, 3);
