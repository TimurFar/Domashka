// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) {return akkerman(m - 1, 1);}
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равна {akkerman(m, n)} ");