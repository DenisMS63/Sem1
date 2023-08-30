// Программа отображает массив из 8 элементов, заполненный 
//нулями и единицами в случайном порядке

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    Console.Write($" |");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
}

int[] array = new int[8];

FillArray(array);
Console.WriteLine($"Массив из случайных нулей и единиц");
PrintArray(array);