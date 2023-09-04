// Произведение пар чисел в одномерном массиве. Парой считаются: первый и
// последний элементы; второй и предпоследний эл-ты и т.д.
// Результат записать в новом массиве.

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

int[] ArrayElemPairMultiplication(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = arr[i] * arr[arr.Length - 1 - i];
        if (i == size - 1) result[i] = arr[i];
    }
    //if (arr.Length % 2 == 1) result[size - 1] = arr[arr.Length / 2]; от преподавателя
    return result;
}



int[] ar1 = CreateRandomArray(7, -5, 5);

Console.WriteLine($"Массив из случайных элементов");
PrintArray(ar1);

Console.WriteLine($"Новый массив, произведение пар эл-тов");
int[] ar2 = ArrayElemPairMultiplication(ar1);
PrintArray(ar2);