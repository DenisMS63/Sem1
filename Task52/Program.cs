// Программа создает случайный двумерный массив и считает среднее арифметическое 
// столбцов массива 

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

void PrintArray(double[] arr)
{
    Console.Write($" [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($" {arr[i]:F2}. ", 5);
        else Console.Write($" {arr[i]:F2}. | ", 5);
    }
    Console.WriteLine($" ]");
}

double[] AverageOfColumn(int[,] arr)
{
    double sum = 0;
    double[] result = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;


        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }

        result[j] = sum / arr.GetLength(0);
    }
    return result;
}

double[] SumOfColumn(int[,] arr)
{
    double sum = 0;
    double[] result = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;


        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }

        result[j] = sum;
    }
    return result;
}



int[,] createRandomMatrix = CreateRandomMatrix(5, 4, 1, 5);

Console.WriteLine($"Двумерный массив (рандомный)\n");
PrintMatrix(createRandomMatrix);

double[] averageOfColumn = AverageOfColumn(createRandomMatrix);
Console.WriteLine($"Значения среднего арифметического по каждому столбцу");
PrintArray(averageOfColumn);

double[] sumOfColumn = SumOfColumn(createRandomMatrix);
Console.WriteLine($"Сумма по столбцам");
PrintArray(sumOfColumn);