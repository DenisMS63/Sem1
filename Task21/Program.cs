// Программа принимает на вход три координаты двух точек в пространстве
// и находит расстояние между ними (3D)

Console.WriteLine($"Введите координаты первой точки");
Console.Write($"X - ");
double x1Point = Convert.ToDouble(Console.ReadLine());
Console.Write($"Y - ");
double y1Point = Convert.ToDouble(Console.ReadLine());
Console.Write($"Z - ");
double z1Point = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите координаты второй точки");
Console.Write($"X - ");
double x2Point = Convert.ToDouble(Console.ReadLine());
Console.Write($"Y - ");
double y2Point = Convert.ToDouble(Console.ReadLine());
Console.Write($"Z - ");
double z2Point = Convert.ToDouble(Console.ReadLine());

double DistanceBetweenTwoPoints3D (double x1, double y1, double z1, double x2, double y2, double z2)
{  
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

double result = Math.Round(DistanceBetweenTwoPoints3D(x1Point, y1Point, z1Point, x2Point, y2Point, z2Point), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");