// Программа принимает на вход число N и отображает таблицу 
// кубов чисел от 1 до N

Console.WriteLine($"Введите число N");
int inputN = Convert.ToInt32(Console.ReadLine());

void TableOfCubes (int N, int x)
{
    Console.WriteLine($"Таблица квадратов чисел от 1 до N:");
    for (int i = 1; i <= N; i++)
    {
        double cube = Math.Pow(i, x);
        Console.WriteLine($"{i, 3} -> {cube, 5}");
    }
}

TableOfCubes (inputN, 3);
