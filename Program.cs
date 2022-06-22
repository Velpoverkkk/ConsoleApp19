using System;
class Program
{   //Задана матрица размером NxM.Упорядочить её  столбцы по возрастанию их наименьших элементов.
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 40);
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
        System.Console.WriteLine();
        for (int i = 0; i < N * M * 10; i++)
        {
            for (int j = 0; j < N-1; j++)
            {
                if (search_min(array, j,N) > search_min(array, j + 1,N))
                {
                   array=sort(array, N, j);
                }
            }
        }
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
    }
    static int search_min(int[,]a,int b,int c)
    {
        int min = a[0, b];
        for(int i = 0; i < c; i++)
        {
            if (min > a[i,b]) min = a[i,b];
        }
        return min;
    }
    static int[,] sort(int[,] a,int b,int j)
    {
        int t;
        for(int i = 0; i < b; i++)
        {          
            t=a[i,j];
            a[i, j] = a[i , j+1];
            a[i , j+1] = t;
             
        }
        return a;
    }

}
