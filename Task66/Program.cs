// РЕКУРСИЯ Программа принимает на вход числа M и N, затем программа находит сумму
// всех чисел в промежутке от M до N

Console.Write($"Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < numberN)
{
int sumOfNumbersFromMtoN = SumOfNumbersFromMtoN(numberM, numberN);
Console.Write($"Сумма чисел на промежутке от M до N -> {sumOfNumbersFromMtoN}");
}
else Console.Write($"\nОШИБКА: число М больше числа N, введите заново");


int SumOfNumbersFromMtoN(int m, int n)
{

    if (m > n) return 0;
    return m + SumOfNumbersFromMtoN(m + 1, n);





}