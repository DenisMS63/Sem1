// Программа создает случайный двумерный массив и затем элементы в каждой строке 
// упорядочивает по убыванию .

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

void DescendingElemsInEachRow(int[,] arr)
{



    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {

                if (arr[i, j] > arr[i, k])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }

}

int[,] createRandomMatrix = CreateRandomMatrix(3, 5, -1, 5);
Console.WriteLine($"Двумерный массив (рандомный)");
PrintMatrix(createRandomMatrix);

Console.WriteLine($"Строки матрицы по убыванию");
DescendingElemsInEachRow(createRandomMatrix);
PrintMatrix(createRandomMatrix);