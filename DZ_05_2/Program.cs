// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int sum = 0;
int[] array = GetArray(7, 01, 99); 
PrintArray(array);
Console.WriteLine($"Сумма чисел нечётных позиций равна = {UnParity(sum)} ");

int [] GetArray(int size, int minValue, int maxVakue) 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxVakue +1);
    }
    return res;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}

int UnParity(int sum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 != 0)
        sum = sum + array[i];
    }

    return sum;
}
