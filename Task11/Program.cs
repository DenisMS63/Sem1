//Программа генерирует случайное трехзначное число 
// и удаляет из него вторую цифру

int rand = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число - {rand}");


int number = GetNumber(rand);
Console.WriteLine($"Трехзначное число без второй цифры - {number}");

int GetNumber(int num)
{
    int num1 = rand / 100;
    int num2 = rand % 10;
    int result = num1 * 10 + num2;

    return result;
}