// Пользователь вводит N чисел, затем вводит число М для проверки массива
// по методу "количество чисел в массиве которые больше числа М"

int[] ArrayByUser(int amo)
{
    int[] result = new int[amo];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(Console.ReadLine());
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

int CheckArrayByNumber (int[] arr, int num)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > num) count++;
    }
    return count;
}

Console.Write($"Введите количество чисел на проверку: ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.Write($"\nВведите число для проверки по методу: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nВведите числа которые должны пройти проверку:");

int[] arrayByUser = ArrayByUser(amount);

Console.WriteLine($"Введенные Вами числа в виде массива");
PrintArray(arrayByUser);

int checkArrayByNumber = CheckArrayByNumber (arrayByUser, number);
Console.WriteLine($"\nЧисел больше чем: {number}  ->  [ {checkArrayByNumber} ]");