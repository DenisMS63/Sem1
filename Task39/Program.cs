// Программа создает массив из случайных чисел и затем совершает
// перестановку элементов в обратно порядке 

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

int[] ArrayElemsInReverseOrder(int[] arr)
{
    int[] result = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[arr.Length - 1 - i];
    }
    return result;
}

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] ar1 = CreateRandomArray(5, 0, 100);
int[] ar2 = ArrayElemsInReverseOrder(ar1);

Console.WriteLine($"Массив из случайных чисел");
PrintArray(ar1);

Console.WriteLine($"Массив в обратном порядке");
PrintArray(ar2);

Console.WriteLine($"Массив в обратном порядке (void)");
ReverseArray(ar1);
PrintArray(ar1);

Console.WriteLine($"Массив в обратном порядке (встроенный метод)");
Array.Reverse(ar1);
PrintArray(ar1);