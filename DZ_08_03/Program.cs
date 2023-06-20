// // Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// // находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18


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

          // метод для умножения матриц
 int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }




Console.WriteLine("Введите количество строк первой матрицы");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество стобцов первой матрицы");
int n = int.Parse(Console.ReadLine()!);
int [,] matrix = new int [m,n];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Первая матрица: ");
PrintArray(matrix);

Console.WriteLine("Введите количество строк второй матрицы");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество стобцов второй матрицы");
int n1 = int.Parse(Console.ReadLine()!);
int [,] matrix1 = new int [m1,n1];
FillArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix1);
Console.WriteLine();

Console.WriteLine("Произведение двух матриц равно: ");
PrintArray(MatrixMultiplication(matrix, matrix1));

