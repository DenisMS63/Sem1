// Программа создает двумерный случайный массив, затем элементы массива 
// у которых оба индекса четные заменяет их значения на квадрат этого элемента

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

void BothIndexIsEvenToSquareNumber(int[,] arr)
{    
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {             
            arr[i, j] *= arr[i, j];             
        }
    }    
}

int [,] createRandomMatrix = CreateRandomMatrix(3, 4, 1, 9);

Console.WriteLine($"Двумерный массив (рандомный)\n", 6);
PrintMatrix(createRandomMatrix);

BothIndexIsEvenToSquareNumber(createRandomMatrix);
Console.WriteLine($"Двумерный массив (по методу)\n", 6);
PrintMatrix(createRandomMatrix);