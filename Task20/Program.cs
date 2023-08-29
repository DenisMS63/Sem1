// Программа принимает на вход координаты двух точек 
// и определяет расстояние между ними на плоскости (2D пространство)

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
    // double diffX = x2 - x1;
    // double diffY = y2 - y1;
    // double sqrtX = Math.Pow(diffX, 2);
    // double sqrtY = Math.Pow(diffY, 2);
    // double sumOfPow = sqrtX + sqrtY;
    
    // double distance = Math.Sqrt(sumOfPow);

    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    double result = Math.Round(distance, 2, MidpointRounding.ToZero);
    return result;
}

Console.WriteLine($"Расстояние между точками: {DistanceBetweenTwoPoints2D(x1Point, y1Point, x2Point, y2Point)}");
