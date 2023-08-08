// Программа принимает на входе два числа и определяет
// является ли первое число квадратом второгого числа

try {
Console.WriteLine("Введите первое число");
int big = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int small = Convert.ToInt32(Console.ReadLine()); 



int square = small * small;

if (square == big) 
{Console.WriteLine($"Число {big} является квадратом числа {small}");}

else 
{Console.WriteLine($"Число {big} не является квадратом числа {small}");}
}

catch {Console.WriteLine("Введено некорректное значение!");}



