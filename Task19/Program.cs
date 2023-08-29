// Программа принимает на вход пятизначное число и проверяет
// является ли оно палиндромом

bool CheckPalindrome (int num)
{
    int digit1 = num / 10000;
    int digit2 = (num / 1000) % 10;
    int digit4 = (num / 10) % 10;
    int digit5 = num % 10;

    return digit1 == digit5 && digit2 == digit4;
}

Console.WriteLine($"Введите пятизначное число"); // 21512
int input = Convert.ToInt32(Console.ReadLine());

if (input > 9999 && input < 100000)
{
    Console.WriteLine(CheckPalindrome (input) ? "Да, введеное число Палиндром" : "Нет, введеное число не Палиндром");
}
else Console.WriteLine("Не пятизначное число");