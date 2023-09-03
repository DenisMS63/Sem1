// Программа задает массив из 123 случайных чисел и находит 
// количество двухзначных значений

int [] CreateRandomArray (int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($" |");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |", 5);
    }
    Console.WriteLine();
}

int NumberOfTwoDigits (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100) count ++;
        if (arr[i] > -100 && arr[i] < -9) count ++;
    }
    return count;
}

int [] ar1 = CreateRandomArray (123, -11, 11);

Console.WriteLine($"Массив из случайных элементов");
PrintArray(ar1);

Console.WriteLine($"Количество двухзначных элементов в массиве");
Console.WriteLine(NumberOfTwoDigits (ar1));