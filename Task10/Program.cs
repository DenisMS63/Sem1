// Программ принимает на вход трехзначное число 
// и сообщает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000) 
    Console.WriteLine($"Вторая цифра введенного числа - {GetSecondDigit(number)}");
else    
    Console.WriteLine("Некорректный ввод");

int randNum = new Random().Next(100, 1000);
Console.WriteLine($"\n Случайное трехзначное число - {randNum}");
Console.WriteLine($"Вторая цифра случайного числа - {GetSecondDigit(randNum)}");


int GetSecondDigit(int num)
{
    int result = (num / 10) % 10;
    return result;
}