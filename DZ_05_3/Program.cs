// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.Clear();
double difference = 0;
double[] array = GetArray(6); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разность между максимальным и минимальным элементом массива равна = {Diff(difference)} ");
double [] GetArray(int size) 
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = (new Random().Next(01, 99)*0.3);
    }
    return res;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}
double Diff(double difference)
{   double min = array[0];
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine();
Console.Write($" Максимум равен {max}");
Console.WriteLine();
Console.Write($" Миниимум равен {min}");
Console.WriteLine();
    difference = max - min;
    return difference;
}