//Программа принимает на вход число N 
//и выводит все четные числа от 1 до N

Console.WriteLine("Введите положительное число N");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные числа от 1 до N");
for (int i = 2; i <= n1; i += 2)
{
    Console.Write($" {i}");
}