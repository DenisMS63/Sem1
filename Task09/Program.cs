//Программа выводи случайное число на отрезке от 10 до 99
// и показывает наибольшую цифру этого числа

int num = new Random().Next(10, 100); 

Console.WriteLine($"Случайное число на отрезке от 10 до 99");
Console.WriteLine($"Число - {num}");

int num2 = num % 10;
int num3 = (num - num2)/10;

int max = num2;

if (num3 > max) 
{
    Console.WriteLine($"Наибольшая цифра - {num3}");
}
else Console.WriteLine($"Наибольшая цифра числа {num} это {num2}");
