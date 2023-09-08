// Программа создает двумерный случайный массив заполненный
// вещественными числами

double[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    double[,] arr = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return arr;
}

void PrintMatrix(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]:F1}. ");
        }
        Console.WriteLine($" ]\n");
    }
}
 
double[,] createRandomMatrix = CreateRandomMatrix(3, 4, -1, 5);

Console.WriteLine($"Двумерный массив из вещественных чисел (рандомный)\n");
PrintMatrix(createRandomMatrix);