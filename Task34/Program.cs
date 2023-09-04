// Программа задает одномерный массив из случайных трехзначных чисел
// и определяет количество четных элеменетов 

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

int AmountOfEvenNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count ++;
    }
    return count;
}

int[] ar1 = CreateRandomArray(8, 100, 999);

Console.WriteLine($"Массив из случайных трехзначных чисел");
PrintArray(ar1);

Console.Write($"Количество ЧЕТНЫХ эл-тов -> [ {AmountOfEvenNumbers (ar1)} ]");
