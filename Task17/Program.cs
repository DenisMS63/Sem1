// Программа принимает на вход координаты точки (x, y),
// причем X != 0 и Y != 0 и выдает номер четверти плоскости 
// в которой находится эта точка 

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите первую координату точки ( х )");
int xCord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки ( y )");
int yCord = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCord, yCord);

string result = quarter > 0 ? $"Точка находится в четверти №{quarter}"
                               : $"Введены некоректные данные";
Console.WriteLine(result);