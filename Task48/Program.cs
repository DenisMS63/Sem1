// Программа создает двумерный массив, каждый элемент массива 
// находится по офрмуле [Amn = m + n] и затем отображает массив 


int[,] CreateMatrixBySumIndex(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
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

int [,] createMatrixBySumIndex = CreateMatrixBySumIndex(3, 4);

Console.WriteLine($"\nДвумерный массив (сумма индексов)\n");
PrintMatrix(createMatrixBySumIndex);