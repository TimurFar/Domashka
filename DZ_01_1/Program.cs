// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ведите числа А и В");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int Max = 0;
int Min = 0;
if(A > B)
{    
    Max = A;
    Min = B;
}
else
{
    Max = B;
    Min = A;
}
Console.WriteLine("Max =" + Max);
Console.WriteLine("Min =" + Min);