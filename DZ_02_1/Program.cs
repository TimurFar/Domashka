// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("введите число от 100 до 999"); // первый вариант решения
// int A = int.Parse(Console.ReadLine());
// if (A > 99 & A < 1000) 
// {
//     Console.WriteLine((A%100)/10);
// }
// else
// {
//     Console.WriteLine("Вне диапазона");
// }

int FindSecondDigit(int number)  //второе решение
{
    int secondDigit = (number / 10) % 10;
    return secondDigit;
}

void FindDigit(int number, int secondDigit)
{
    if(number > 99 && number < 1000)
{
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Вне диапазона");
}
}

Console.WriteLine("введите число от 100 до 999");
int number = int.Parse(Console.ReadLine());
int numberSecond = FindSecondDigit(number);
FindDigit(number, numberSecond);
