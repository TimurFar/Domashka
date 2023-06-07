// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void result (int X)
{
    if(Math.Abs(X) <= 10)
{
    Console.WriteLine(X);
}
    if(Math.Abs(X) > 10 && X < 100)
{
    Console.WriteLine((X/10)+(X%10));
}
    if (Math.Abs(X) > 99 & Math.Abs(X) < 1000) 
{
    Console.WriteLine((X/100)+(X%10)+((X%100)/10));
}
    if (Math.Abs(X) > 999 & Math.Abs(X) < 10000)
{
    Console.WriteLine((X/1000)+(X%10)+((X%100)/10)+((X/100)%10));
}
    if (Math.Abs(X) > 9999 & Math.Abs(X) < 100000)
{
    Console.WriteLine((X/10000)+(X%10)+((X%100)/10)+((X/100)%10)+((X/1000)%10));
}
}
Console.WriteLine("Введите число X");
int X = int.Parse(Console.ReadLine());
Console.WriteLine();
result(X);