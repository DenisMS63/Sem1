// Программа принимает на вход 3 числа (длины сторон треугольника)
// и проверяет может ли существовать треугольник с такими сторонами

bool CheckTriangleExist (int n1, int n2, int n3)
{    
    // if (n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1) return true;
    // else return false;

    return n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1;
}

Console.WriteLine($"Проверка по Теореме о неравенстве треугольника");
Console.Write($"Введите длину стороны А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите длину стороны B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите длину стороны C: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write(CheckTriangleExist (a, b, c) ? $"Такой треугольник [ Cуществует ] " 
: "Такой треугольник [ НЕ существует ]");