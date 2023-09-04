// Программа задает массив вещественных чисел и находит
// разницу между максимальным и минимальным элементами 


double[] CreateRandomArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write($" [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($" {arr[i]:F3}. ", 5);
        else Console.Write($" {arr[i]:F3}. | ", 5);
    }
    Console.WriteLine($" ]");
}

double MaxOfArray (double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinOfArray (double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxMinDifference (double max, double min)
{
    //double result = max - min;
    return max - min;
}

double[] ar1 = CreateRandomArray(3, 0, 5);

Console.WriteLine($"Массив из случайных вещественных чисел");
PrintArray(ar1);

Console.WriteLine($"Разница максимального и минимального эл-ов {MaxMinDifference (MaxOfArray (ar1), MinOfArray (ar1))}");