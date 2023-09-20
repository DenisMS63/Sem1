// Программа создает двумерный массив и находит строку с наименьшей суммой 
// элементов

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

int [] SumsOfRowsInMatrix (int[,] arr)
{
    int [] res = new int [arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        res [i] = sum;
    }
    return res;
}

void FindRowWithMaxSum (int [] arr)
{
    int maxInd = 0;
    int nextInd;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[maxInd]) maxInd = i;
        
    }
    Console.WriteLine($"Строка с наибольшей суммой элементов -> {maxInd + 1}");
}

void PrintArray(int [] arr)
{
    Console.Write($" [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($" {arr[i]}. ");
        else Console.Write($" {arr[i]}. | ");
    }
    Console.WriteLine($" ]");
}

int[,] createRandomMatrix = CreateRandomMatrix(5, 3, -1, 5);
Console.WriteLine($"Двумерный массив (рандомный)");
PrintMatrix(createRandomMatrix);



int [] sumsOfRowsInMatrix = SumsOfRowsInMatrix (createRandomMatrix);
PrintArray(sumsOfRowsInMatrix);
FindRowWithMaxSum (sumsOfRowsInMatrix);
