// Программа создает двумерный случайный массив и меняет местами 
// первую и последнюю строки

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
            Console.Write($"{arr[i, j],3}.");
        }
        Console.WriteLine($" ]\n");
    }
}

void SwapFirstRowAndLastRow(int[,] arr)
{
    int firstRow = 0;
    int lastRow = arr.GetLength(0) - 1;

    for (int j = 0; j < arr.GetLength(1); j++)
    {

        int temp = arr[firstRow, j];
        arr[firstRow, j] = arr[lastRow, j];
        arr[lastRow, j] = temp;

    }

}

int[,] createRandomMatrix = CreateRandomMatrix(5, 4, 1, 5);

Console.WriteLine($"Двумерный массив (рандомный)\n");
PrintMatrix(createRandomMatrix);

SwapFirstRowAndLastRow(createRandomMatrix);
Console.WriteLine($"Двумерный массив (по методу)\n");
PrintMatrix(createRandomMatrix);