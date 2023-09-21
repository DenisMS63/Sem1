// Программа совершает перемножение двух матриц

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

int [,] MultiplicationOfMatrix (int [,] arrA, int [,] arrB)
{
    if (arrA.GetLength(1) != arrB.GetLength(0))
    {
        Console.WriteLine($"ОШИБКА: перемножить матрицы невозможно");
    }
    
    int [,] arrC = new int [arrA.GetLength(0), arrB.GetLength(1)];

    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            arrC [i, j] = 0;
            for (int k = 0; k < arrA.GetLength(1); k++)
            {
                arrC [i, j] += arrA[i, k] * arrB [k, j];
            }
        }
    }
    return arrC;
}

int[,] createRandomMatrix = CreateRandomMatrix(4, 2, 1, 5);
Console.WriteLine($"\nДвумерный массив (рандомный)");
PrintMatrix(createRandomMatrix);

int[,] createRandomMatrix2 = CreateRandomMatrix(2, 4, 1, 5);
Console.WriteLine($"\nДвумерный массив №2 (рандомный)");
PrintMatrix(createRandomMatrix2);

int [,] multiplicationOfMatrix = MultiplicationOfMatrix (createRandomMatrix, createRandomMatrix2);
Console.WriteLine($"\nДвумерный массив №3 (перемножение матриц)");
PrintMatrix(multiplicationOfMatrix);