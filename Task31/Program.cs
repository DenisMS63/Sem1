// Программа задает массив из 12 элементов заполненный случайными числами
// из промежутка (-10, 10).
// Найти сумму всех отрицательных и положительных элементов массива.

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 11);
    }
}

void PrintArray(int[] arr)
{
    Console.Write($" |");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
    Console.WriteLine();
}

int SumOfNegative (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) 
        {
            sum += arr[i];
        }
    }
    return sum;
}

int SumOfPositive (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        {
            sum += arr[i];
        }
    }
    return sum;
}

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

int [] SumPositiveAndNegative (int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) 
        {
            sumNeg += arr[i];
        }
        else
        {
            sumPos += arr[i];
        }
    }
    
    return new int [] {sumNeg, sumPos};
}

int [] array = new int [12];

// Console.WriteLine($"Введите диапозон значений для массива: ");
// Console.Write($"от ");
// int from = Convert.ToInt32(Console.ReadLine());
// Console.Write($"до ");
// int to = Convert.ToInt32(Console.ReadLine());

FillArray(array);
Console.WriteLine($"Массив из случайных элементов");
PrintArray(array);
Console.WriteLine($"Сумма отрицательных элементов: {SumOfNegative (array)}");
Console.WriteLine($"Сумма положительных элементов: {SumOfPositive (array)}");
PrintArray(CreateRandomArray (5, -5, 5));

int [] sumPositiveAndNegative = SumPositiveAndNegative (array);
Console.WriteLine($"Сумма положительных элементов: {sumPositiveAndNegative[1]}");
Console.WriteLine($"Сумма отрицательных элементов: {sumPositiveAndNegative[0]}");