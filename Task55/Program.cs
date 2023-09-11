// Программа задает двумерный массив и осуществляет замену строк на столбцы

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

void SwapRowsToColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < i; j++) // работаем с нижним треугольником по главной диагональю
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }

}

bool IsMatrixSquare (int[,] arr)
{
    return arr.GetLength(0) == arr.GetLength(1);
}

int[,] createRandomMatrix = CreateRandomMatrix(3, 3, 10, 99);


Console.WriteLine($"Двумерный массив (рандомный)\n");
PrintMatrix(createRandomMatrix);


if (IsMatrixSquare (createRandomMatrix)) 
{
Console.WriteLine($"Двумерный массив (по методу)\n");
SwapRowsToColumns(createRandomMatrix);
PrintMatrix(createRandomMatrix);
}
else Console.WriteLine($"ОШИБКА: массив не квадратный");



