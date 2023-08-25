// Программа по введенному номеру четверти сообщается 
// диапозон возможных координат точек в этой четверти

string Range (int x)
{
    if (x == 1) return "Данная четверть соответствует диапазону: x > 0, y > 0";
    if (x == 2) return "Данная четверть соответствует диапазону: x < 0, y > 0";
    if (x == 3) return "Данная четверть соответствует диапазону: x < 0, y < 0";
    if (x == 4) return "Данная четверть соответствует диапазону: x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

if (Range(quarter) == null) Console.WriteLine("Несуществующая четверть");
else Console.WriteLine(Range(quarter));
