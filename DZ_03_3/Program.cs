// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

int Prompt (string message)
{
    Console.Write(message);
    int num_n = int.Parse(Console.ReadLine()!);
    return num_n;
}
int i = 1;

void PrintTable(int number)
{
    while (i <= number)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }
}
int num = Prompt ("Введите чило N ");
int number = Math.Abs(num);
PrintTable(number);