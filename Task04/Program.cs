//Программа получает на входе 3 числа 
//и определяет число с большим значеним

Console.WriteLine("Введите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"MAX = {n1}");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"MAX = {n2}");
}
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"MAX = {n3}");
}
else { Console.WriteLine($"ERROR"); }
