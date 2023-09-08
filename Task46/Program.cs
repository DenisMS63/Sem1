// Программа создает двумерный массив заполненный случайными числами
// и затем отображает его в консоль

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}.", 5);           
        }
        Console.WriteLine($" ]\n"); 
    }    
}

int [,] createRandomMatrix = CreateRandomMatrix(3, 4, 10, 99);

Console.WriteLine($"Двумерный массив (рандомный)\n", 6);
PrintMatrix(createRandomMatrix);