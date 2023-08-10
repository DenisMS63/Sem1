//Программа выводи случайное число на отрезке от 10 до 99
// и показывает наибольшую цифру этого числа

int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное число на отрезке от 10 до 99");
Console.WriteLine($"Число - {number}");

// int num2 = num % 10;
// int num3 = num / 10;

// if (num3 > num2) 
// {
//     Console.WriteLine($"Наибольшая цифра - {num3}");
// }
// else Console.WriteLine($"Наибольшая цифра числа {num} это {num2}");

// int result = num2 > num3 ? num2 : num3;
// Console.WriteLine($"Наибольшая цифра - {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра - {maxDigit}");

int maxDigit1 = MaxDigit(12);
Console.WriteLine($"Наибольшая цифра - {maxDigit1}");

int MaxDigit(int num)
{
    int num2 = num % 10;
    int num3 = num / 10;    
    return num2 > num3 ? num2 : num3;
}