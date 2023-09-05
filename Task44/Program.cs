// Не используя рекурсию, вывести первые числа Фибоначчи по числу N от пользователя

int[] FibonacciNumbers(int n)
{
    int[] result = new int[n];
    result[0] = 0;
    result[1] = 1;

    if (n == 2) return result;
    for (int i = 2; i < n; i++)
    {
        checked
        {
            result[i] = result[i - 1] + result[i - 2];
        }

    }
    return result;
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


Console.Write($"Введите требуемое количество чисел Фибоначчи: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    int[] fibonacciNumbers = { 0 };
    PrintArray(fibonacciNumbers);
}
else
{
    int[] fibonacciNumbers = FibonacciNumbers(num);
    PrintArray(fibonacciNumbers);
}