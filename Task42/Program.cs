// Программа преобразовывает десятичное число в двоичное

string DecimalNumToBinary (int num)
{
    string binary = string.Empty;

    while (num > 0)
    {
        binary = num % 2 + binary;
        num /= 2; 
    } 
    return binary;
}

int DecimalNumToBinary_2 (int num)
{
    int binary = 0;
    int mult = 1;
    while (num != 0)
    {
        binary += mult * (num % 2);
        num /= 2;
        mult *= 10; 
    }
    return binary;
}

Console.Write($"Введите десятичное число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Число {x} в двоичном представлении (string) -> [ {DecimalNumToBinary (x)} ]");
Console.WriteLine ($"Число {x} в двоичном представлении (int) -> [ {DecimalNumToBinary_2 (x)} ]");