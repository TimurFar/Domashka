
// Задача 66. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15; -> 120
// M = 4; N = 8; -> 30


string message = "Введите значение M ";
int M = Input(message);
Console.WriteLine();
string msg = "Введите значение N ";
int N = Input(msg);
Console.WriteLine();
int result = Summ(M, N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {result}");


int Input (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;

}

int Summ (int a, int b)
{ int sum = 0;
    if (a <= b)
    {
    for (int i = a; a <= b; a++)
    sum += a;
    }
    else 
    Console.WriteLine("Неверно задано значение M");
    return sum;

}
