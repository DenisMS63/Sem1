// Программа получает от пользователя два числа и выводит max и min

Console.WriteLine("Введите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int n2 = Convert.ToInt32(Console.ReadLine());


if (n1 > n2)
{
    Console.WriteLine($"MAX = {n1} MIN = {n2}");
}
else if (n2 > n1)
{
    Console.WriteLine($"MAX = {n2} MIN = {n1}");
}
else { Console.WriteLine($"ERROR"); }