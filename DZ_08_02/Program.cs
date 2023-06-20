// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

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

double [] GetResultAarray (int [,] array)
{
    double [] result = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0; 
        for (int j =0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        result [i] = Math.Round(sum, 2); 
        
    }
    return result;
}

void  MinSum(double [] matrix)
{
    double min = matrix [0];
    double number = 0;
        for (int i =0; i < matrix.Length; i++)
        {
            if (min > matrix [i])
        {
            min = matrix [i];
            number = i;
        }
                    // Console.WriteLine(matrix [i]);
               }
         Console.WriteLine($"Значение min равно {min} ");
        Console.WriteLine($"Строка с наименьшей суммой иммет номер = {number}");
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество стобцов");
int n = int.Parse(Console.ReadLine()!);
int [,] matrix = new int [m,n];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
double [] AllSum = GetResultAarray(matrix);
Console.WriteLine($"Сумма каждой строки = {String.Join("; ", AllSum)}");
Console.WriteLine();
double [] sums = GetResultAarray(matrix);
MinSum(sums);







