// Программа генерирует массив из случаный чисел 
//и записывает значения в порядке возрастания  

Console.WriteLine("Массив из случайных чисел");


void RandArr(int n)
{
    int[] arr = new int [n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 10);
        Console.Write($"{arr[i]} ");
    }    
}

void SortArr (int [] ar)
{
    int min = ar [0];
    int temp = ar [1];

    for ( int i = 0; i < ar.Length; i ++)
    {
        for ( int j = 0; )
    }
}

RandArr(10);