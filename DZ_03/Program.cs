// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int FirstDigit(int number)
{
    int first = number / 10000;
    return first;
}
int SecondtDigit(int number)
{
    int second = (number / 1000)%10;
    return second;
}
int FourthDigit(int number)
{
    int fourth = (number/10) % 10;
    return fourth;
}
int FifthDigit(int number)
{
    int fifth = number % 10;
    return fifth;
}

void FindPalindrom(int number, int first, int second, int fourth, int fifth)
{
    Console.WriteLine(first);
    Console.WriteLine(second);
    Console.WriteLine(fourth);
    Console.WriteLine(fifth);
}

Console.WriteLine("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine());

FindPalindrom(number, FirstDigit(number), SecondtDigit(number), FourthDigit(number), FifthDigit(number));

if(99999 < number | number < 10000)
{
   Console.WriteLine("Заданное число вне диапазона "); 
}

if(FirstDigit(number) == FifthDigit(number) && SecondtDigit(number) == FourthDigit(number))
{
   Console.WriteLine("Заданное число является палиндромом "); 
}
else
{
   Console.WriteLine("Заданное число не является палиндромом "); 
 }

