// Программа определяет есть ли в массиве число которое 
// ввел пользователь

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

void PrintArray(int [] arr)
{
    Console.Write($" [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($" {arr[i]}. ", 5);
        else Console.Write($" {arr[i]}. | ", 5);
    }
    Console.WriteLine($" ]");
}

bool NumberInArray (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;        
    }   
    return false; 
}


int [] ar1 = CreateRandomArray (10, -10, 10);

Console.WriteLine($"Массив из случайных элементов");
PrintArray(ar1);

Console.Write($"Введите число для поиска по массиву: ");
int number = Convert.ToInt32(Console.ReadLine());

//string result = NumberInArray (ar1, number) ? "Да, такое число есть" : "Нет такого числа";
//Console.WriteLine($"Результат поиска числа по массиву: {result}");

Console.WriteLine(NumberInArray (ar1, number) ? "Да, такое число есть" : "Нет такого числа");
