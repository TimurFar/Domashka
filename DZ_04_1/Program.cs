// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Calculate(int A, int B)
{
   int result = 1;
   for(int i = 1 ;i <= B; i++)
{
    int calc = result * A;
    result = calc;
    }
Console.WriteLine(result);
}

Console.WriteLine("Введите числа А и В");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
Console.WriteLine();
Calculate(A, B);
