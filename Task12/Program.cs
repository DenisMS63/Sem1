// Программа принимает на вход 2 числа и выводит является ли
// первое число крастным второму. Если не кратно то выводится 
// остаток от деления.

Console.WriteLine("Проверим кратность первого числа относительного второго числа");
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());


int RemainderOfTheDivison(int n1, int n2)
{
    int num = n1 % n2;

    return num;    
}

int result = RemainderOfTheDivison(num1, num2);


if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Некратно, остаток от деления - {result}");
