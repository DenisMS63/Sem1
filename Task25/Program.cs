// Программа принимает два числа (А и В) и возводит
// число А в натуральную степень В

int NumbertoPower(int A, int B)
{
    int result = 1;    
    if (B == 0) return 1;
    if (B == 1) return A;    
    else
    {
        for (int i = 0; i < B; i++)
        {
            result *= A;
        }
    }
    return result;
}

Console.Write($"Введите целое число А: ");
int inputA = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите натуральную степень B: ");
int inputB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {inputA} в степени {inputB} -> {NumbertoPower(inputA, inputB)}");
