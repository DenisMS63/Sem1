//Программа для отображение чисел от -N До N. Число N вводит пользователь.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;

while (i<=num) {
    Console.WriteLine(i);
    i += 1;
}