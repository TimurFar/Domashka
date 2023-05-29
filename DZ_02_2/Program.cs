// Console.WriteLine("Hello, World!");

// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число от 100 до 999");
int A = int.Parse(Console.ReadLine());
if (A > 99 & A < 1000) 
{
    Console.WriteLine(A%10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}