// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

 Console.WriteLine("Введите числа A и B!");  // моё решение
 int A = int.Parse(Console.ReadLine());
 int B = int.Parse(Console.ReadLine());

if(A == B*B)
{
    Console.WriteLine("Число A является квадратом числа B!");
}
else if(B == A*A)
{
    Console.WriteLine("Число B является квадратом числа A!");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого!");
}