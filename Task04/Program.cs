//Программа для отображение чисел от -N До N. Число N вводит пользователь.

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;

while (i<=num) {
    Console.Write($" {i}");
    i += 1;
}