// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


Console.Clear();
int count = 0;
int[] array = GetArray(6, 99, 1000); 
PrintArray(array);
Console.WriteLine($"Количество чётных чисел равно = {Parity(count)} ");

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
    Console.WriteLine();
}

int Parity(int count)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        count = count + 1;
    }

    return count;
}


