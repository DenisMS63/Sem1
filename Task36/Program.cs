// Программа задает одномерный массив заполненный случайными числами
// и находит сумму элементов с НЕчетными индексами 

int[] CreateRandomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($" [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($" {arr[i]}. ", 5);
        else Console.Write($" {arr[i]}. | ", 5);
    }
    Console.WriteLine($" ]");
}

int SumOfElemsWithOddIndex (int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        count += arr[i];
    }
    return count;
}

int[] ar1 = CreateRandomArray(9, -5, 10);

Console.WriteLine($"Массив из случайных чисел");
PrintArray(ar1);

Console.Write($"Сумма эл-тов с НЕчетными индексами -> [ {SumOfElemsWithOddIndex (ar1)} ]");
