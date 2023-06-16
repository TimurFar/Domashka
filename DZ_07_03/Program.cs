// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"  {matr[i,j]}");
        }
        Console.WriteLine();
    }
}

void FillArray (int [,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
            
        }
        
    }
}

void MiddleArif (int [,] matr, int n, int m)
{
   int summ = 0;
   double resultt = 0;
     for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0)
            summ = summ+matr[i,j];
                      
        }
       
        
    }
     Console.WriteLine(summ);
        resultt = summ / n;
        Console.WriteLine($"Среднее арифметическое равно {resultt}");
}

Console.WriteLine("Введите количество строк в массиве");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int n = int.Parse(Console.ReadLine());
int [,] matrix = new int [m,n];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
MiddleArif(matrix, m, n);
