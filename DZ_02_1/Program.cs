//Console.WriteLine("Hello, World!");

// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int FirstDigit(int num)
// {
// int firstNumber = num / 10;
// return firstNumber;
// }
// int SecondDigit(int num)
// {
// int secondNumber = num % 10;
// return secondNumber;
// }

Console.WriteLine("введите число от 100 до 999");
int A = int.Parse(Console.ReadLine());
if (A > 99 & A < 1000) 
{
    Console.WriteLine((A%100)/10);
}
else
{
    Console.WriteLine("Вне диапазона");
}
