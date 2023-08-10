// Программа приминамает на вход число и проверяет
// кратно ли оно 7 и 23 одновременно

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultiplicityTwoNumbers (number, 7, 23);

Console.WriteLine(result ? "Кратно" : "Некратно");


bool MultiplicityTwoNumbers (int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}
