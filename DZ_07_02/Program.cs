// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец

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

void ValueElements (int [,] matr, int m, int n)
{

 for (int i = 1; i < matr.GetLength(0)+1; i++)
    {
        for (int j = 1; j < matr.GetLength(1)+1; j++)
        {   
            
            if (i == m && j == n) 
            { Console.Write($"  {matr[m-1,n-1]}"); }
            if (m>4 | n>4)
            { Console.Write($" Такого числа в массиве нет"); }
                                  
        }
        Console.WriteLine();
        
    }
    
}

Console.WriteLine("Введите позицию в массиве m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию в массиве n");
int n = int.Parse(Console.ReadLine());
int [,] matrix = new int [4,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
ValueElements(matrix, m, n);