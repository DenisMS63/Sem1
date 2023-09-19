// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информаицю о том, сколько раз встречается 
// элемент входных данных.
// Есть двумерный массив, необходимо посчитать сколько каких чисел в массиве.
// Делаем двумерный массив одномерным, сортируем его и подсчитываем числа.

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

int[] MatrixToArray(int[,] arr)
{
    int[] array = new int[arr.GetLength(0) * arr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            array[k] = arr[i, j];
            k++;
        }
    }

    return array;
}

void PrintArray(int[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}. ");
    }
    Console.WriteLine($" ]\n");
}

void FrequencyDictionary(int[] arr) // Частотный словарь
{
    int count = 1;
    int num = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{num} -> {count}");
            count = 1;
            num = arr[i];
        }
        
    }
    Console.WriteLine($"{num} -> {count}");
}


int[,] createRandomMatrix = CreateRandomMatrix(3, 3, 1, 5);
Console.WriteLine($"\nДвумерный массив (рандомный)");
PrintMatrix(createRandomMatrix);

Console.WriteLine($"Массив из матрицы");
int[] matrixToArray = MatrixToArray(createRandomMatrix);
PrintArray(matrixToArray);

Console.WriteLine($"Массив отсортированный");
Array.Sort(matrixToArray);
PrintArray(matrixToArray);

Console.WriteLine($"Метод: Частотный словарь");
FrequencyDictionary(matrixToArray);
