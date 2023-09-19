// Программа создает двумерный массив и целых чисел. Затем удаляет 
// строку и столбец на пересечении которых находится элемент с наименьшим 
// значением. 


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

int [] FindIndexOfMinElement (int [,] mtr)
{
    int row = mtr.GetLength(0);
    int column = mtr.GetLength(1);
    int rowMin = 0;
    int colMin = 0;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (mtr[i, j] < mtr[rowMin, colMin])
            {
                rowMin = i;
                colMin = j;
            }
        }
    }
    return new int [] {rowMin, colMin};
}

int [,] DeleteRowAndColumnOfMinElement (int [,] mtr, int rowMin, int colMin)
{
    int rows = mtr.GetLength(0);
    int columns = mtr.GetLength(1);
    int [,] result = new int [rows - 1, columns - 1];
    int m = 0, n = 0;
    for (int i = 0; i < rows - 1; i++)
    {
        if (m == rowMin) m += 1;

        for (int j = 0; j < columns - 1; j++)
        {
            if (n == colMin) n += 1;
            result [i, j] = mtr [m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}.");
    }
    Console.WriteLine($" ]\n");
}

int[,] createRandomMatrix = CreateRandomMatrix(4, 5, 0, 10);
Console.WriteLine($"\nДвумерный массив (рандомный)");
PrintMatrix(createRandomMatrix);

int [] findIndexOfMinElement = FindIndexOfMinElement (createRandomMatrix);

int [,] deleteRowAndColumnOfMinElement 
= DeleteRowAndColumnOfMinElement (createRandomMatrix, findIndexOfMinElement[0], findIndexOfMinElement[1]);
Console.WriteLine($"\nМатрица без строки и столбца по минимальному элементу");
PrintMatrix(deleteRowAndColumnOfMinElement);