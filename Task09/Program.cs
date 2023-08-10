//Программа выводи случайное число на отрезке от 10 до 99
// и показывает наибольшую цифру этого числа

int num = new Random().Next(10, 100);

Console.WriteLine($"Случайное число на отрезке от 10 до 99");
Console.WriteLine($"Число - {num}");

// int num2 = num % 10;
// int num3 = num / 10;

// if (num3 > num2) 
// {
//     Console.WriteLine($"Наибольшая цифра - {num3}");
// }
// else Console.WriteLine($"Наибольшая цифра числа {num} это {num2}");

// int result = num2 > num3 ? num2 : num3;
// Console.WriteLine($"Наибольшая цифра - {result}");

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра - {maxDigit}");

int MaxDigit(int num)
{
    int num2 = num % 10;
    int num3 = num / 10;    
    return num2 > num3 ? num2 : num3;
}