// Программа создает копию сгенерированного случайного массива
// при помощи поэлементного копирования 

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

int[] CopyOfArray(int[] arr)
{
    int[] result = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

int [] createRandomArray = CreateRandomArray(5, -10, 10);
int [] copyOfArray = CopyOfArray(createRandomArray);
copyOfArray[0] = 100;

Console.WriteLine($"Массив из случайных чисел");
PrintArray(createRandomArray);

Console.WriteLine($"\nМассив скопированный поэлементно");
PrintArray(copyOfArray);

Console.WriteLine($"\nМассив из случайных чисел (проверка)");
PrintArray(createRandomArray);