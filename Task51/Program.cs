// Программа создает случайный массив и подсчитывает сумму элементов 
// на главной диагонали (00, 11, 22 и тд.)

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

// int SumMainDiagonal (int[,] arr)
// {    
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i == j) sum += arr[i,j]; 
//         }
//     }
//     return sum;
// }

int SumMainDiagonal(int[,] arr)
{
    int sum = 0;
    int size = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    
    for (int i = 0; i < size; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

int[,] createRandomMatrix = CreateRandomMatrix(6, 3, -5, 5);

Console.WriteLine($"Двумерный массив (рандомный)\n");
PrintMatrix(createRandomMatrix);

int sumMainDiagonal = SumMainDiagonal(createRandomMatrix);
Console.WriteLine($"Сумма элементов на главной диагонали -> [ {sumMainDiagonal} ]", 6);