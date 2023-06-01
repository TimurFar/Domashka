//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Ведите числа А,В и C");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int Max = 0;
if(A > B && A > C)
{    
    Max = A;
    }
else if (B > A && B > C)
{
    Max = B;
    }
else if (A==B && A > C) 
{
    Max = A;
}
else
{
    Max = C;
    }
Console.WriteLine("Max =" + Max);