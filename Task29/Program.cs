// Программа принимает на вход два крайних значения диапозона 
// и отображает массив из 8 элементов сгенерированных
// псевдо случайныйным обраом

void FillArray(int[] arr, int n1, int n2)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(n1, n2 + 1);
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

Console.WriteLine($"Введите диапозон значений для массива: ");
Console.Write($"от ");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write($"до ");
int to = Convert.ToInt32(Console.ReadLine());

int[] array = new int[8];

FillArray(array, from, to);
Console.WriteLine($"Массив из случайных цифр");
PrintArray(array);