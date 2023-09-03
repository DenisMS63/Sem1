// Программа создает массив и заменяет положительные элементы 
// на отрицательные и на оборот

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

int [] ChangeTheSignOfNumber (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;   
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

int [] ar1 = CreateRandomArray (6, -5, 5);

Console.WriteLine($"Массив из случайных элементов");
PrintArray(ar1);


Console.WriteLine($"Массив с обратными знаками элементов");
PrintArray(ChangeTheSignOfNumber (ar1));