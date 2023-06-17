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
   double summ = 0;
   double summ1 = 0;
   double summ2 = 0;
   double summ3 = 0;
   double resultt = 0;
   double resultt1 = 0;
   double resultt2 = 0;
   double resultt3 = 0;
     for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0)
            summ = summ+matr[i,j];
                      
        }
       for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 1)
            summ1 = summ1+matr[i,j];
                      
        }
         for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 2)
            summ2 = summ2+matr[i,j];
                      
        }
         for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 3)
            summ3 = summ3+matr[i,j];
                      
        }
    }
     Console.WriteLine($"Сумма элементов первой строки {summ}");
        resultt = summ / n;
        Console.WriteLine($"Среднее арифметическое первой строки равно {resultt}");
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов второй строки {summ1}");
        resultt1 = summ1 / n;
        Console.WriteLine($"Среднее арифметическое второй строки равно {resultt1}");
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов третьей строки {summ2}");
        resultt2 = summ2 / n;
        Console.WriteLine($"Среднее арифметическое третьей строки равно {resultt2}");
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов четвёртой строки {summ3}");
        resultt3 = summ3 / n;
        Console.WriteLine($"Среднее арифметическое четвёртой строки равно {resultt3}");
}

int [,] matrix = new int [4,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
MiddleArif(matrix, 4, 4);