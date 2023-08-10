// Программа принимает на вход 2 числа и проверяет 
// является ли первое число квадратом второго числа или наоборот

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = CheckSquareTwoNumbers(number1, number2);
Console.WriteLine(result ? "Да" : "Нет");


bool CheckSquareTwoNumbers(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}