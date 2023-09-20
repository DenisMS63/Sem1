// Программа генерирует массив из случаный чисел 
//и записывает значения в порядке возрастания  

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
        else Console.Write($" {arr[i]}. ", 5);
    }
    Console.WriteLine($"]");
}

void SortArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

Console.WriteLine("Массив из случайных чисел");

int[] createRandomArray = CreateRandomArray(5, 1, 10);
PrintArray(createRandomArray);

SortArr(createRandomArray);
// Array.Sort(createRandomArray);
PrintArray(createRandomArray);