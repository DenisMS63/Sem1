//Программа принимает на вход число
// и определяет четное оно или нечетное

Console.WriteLine("Введите число");
int n1 = Convert.ToInt32(Console.ReadLine());
int x = n1 % 2;

if (x == 0)
{
    Console.WriteLine($"Введеное число - четное");
}
else { Console.WriteLine($"Введеное число -  нечетное"); }
