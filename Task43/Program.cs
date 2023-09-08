// Программа находит точку пересечения двух прямых заданных уравнением
// у = к1 * х + b1, у = к2 * х + b2, значения к1, b1, k2, b2 задаются пользователем

double XCoordinate (double k1, double b1, double k2, double b2)
{    
    return (b2 - b1) / (k1 - k2);
}

double YCoordinate (double k1, double b1, double x)
{    
    return (k1 * x + b1);
}

Console.WriteLine($"Находим точку пересечения двух прямых \nзаданных уравнениями [ у = к1 * х + b1; у = к2 * х + b2 ]");
Console.Write($"\nВведите значение k1: ");
double kk1 = Convert.ToDouble (Console.ReadLine());

Console.Write($"Введите значение b1: ");
double bb1 = Convert.ToDouble (Console.ReadLine());

Console.Write($"Введите значение k2: ");
double kk2 = Convert.ToDouble (Console.ReadLine());

Console.Write($"Введите значение b2: ");
double bb2 = Convert.ToDouble (Console.ReadLine());

if (kk1 == kk2)
{
    Console.WriteLine($"Точки пересечения нет, прямые параллельны друг другу.");
}
else
{
double xCoordinate = XCoordinate (kk1, bb1, kk2, bb2);
double yCoordinate = YCoordinate (kk1, bb1, xCoordinate);

Console.WriteLine($"\nКоордината Х точки пересечения -> [ {xCoordinate} ]");
Console.WriteLine($"Координата Y точки пересечения -> [ {yCoordinate} ]");
}