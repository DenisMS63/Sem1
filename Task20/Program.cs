// Программа принимает на вход координаты двух точек 
// и определяет расстояние между ними на плоскости (2D пространство)
// с округлением до двух чисел после запятой без увеличения значения

Console.WriteLine($"Введите координаты первой точки");
Console.Write($"X - ");
double x1Point = Convert.ToDouble(Console.ReadLine());
Console.Write($"Y - ");
double y1Point = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите координаты второй точки");
Console.Write($"X - ");
double x2Point = Convert.ToDouble(Console.ReadLine());
Console.Write($"Y - ");
double y2Point = Convert.ToDouble(Console.ReadLine());

double DistanceBetweenTwoPoints2D (double x1, double y1, double x2, double y2)
{  
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

double result = Math.Round(DistanceBetweenTwoPoints2D(x1Point, y1Point, x2Point, y2Point), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");
