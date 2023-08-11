// Программа принимает на вход цифру обозначающую день недели
// и сообщает выходной сегодня или нет

Console.WriteLine("Введите цифру обозначающую день недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

int days = 7 - number;
Weekend(number, days);


void Weekend(int num, int day)
{
    if (num < 1) Console.WriteLine("Некорректный ввод");
    else if (num > 7) Console.WriteLine("Некорректный ввод");
    else if (day <= 2) Console.WriteLine("Выходной");
    else if (day > 2) Console.WriteLine("Не выходной");
}
