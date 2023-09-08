// Программа создает двумерный случайный массив, запрашивает у пользователя
// номер строки и номер столбца, проверяет наличие такого элемента и выводит значение

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}.");
        }
        Console.WriteLine($" ]\n");
    }
}

int FindElemOfMatrix (int row, int col, int[,] arr)
{
    return arr[row - 1, col - 1];
}

int[,] createRandomMatrix = CreateRandomMatrix(4, 3, -5, 5);


Console.Write($"Введите номер строки: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца: ");
int userColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nДвумерный массив (рандомный)\n");
PrintMatrix(createRandomMatrix);

int findElemOfMatrix = FindElemOfMatrix (userRow, userColumn, createRandomMatrix);
if(userRow < 0 || userColumn < 0 ) Console.WriteLine($"ОШИБКА: номер не может быть отрицательным");
if(userRow > createRandomMatrix.GetLength(0) || userColumn > createRandomMatrix.GetLength(1)) Console.WriteLine($"ОШИБКА: такого элемента не существует");
else Console.WriteLine($"\nЭлемент по введенным индексам -> [ {findElemOfMatrix} ]");

