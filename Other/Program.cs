// Программа генерирует массив из случаный чисел 
//и записывает значения в порядке возрастания  

Console.WriteLine("Массив из случайных чисел");


void RandArr(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
}

void SortArr(int[] ar)
{


    for (int i = 0; i < ar.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; i < ar.Length; i++)
        {
            if (ar[j] < ar[minPos]) minPos = j;
        }

        int temp = ar[i];
        ar[i] = ar[minPos];
        ar[minPos] = temp;
    }

}

RandArr(10);
int [] array = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SortArr(array));