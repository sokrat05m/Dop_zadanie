/* Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива. */

double [] CreateArrayDouble (int size, double min, double max)
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().NextDouble () * (max - min) + min;
    }
    return array;
}

void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }
}

double FindDiffMaxMin (double [] array)
{
    int i = 0;
    double min = array [i];
    double max = array [i];
    for (i = 0; i < array.Length - 1; i++)
    {
        if (array [i] > max) max = array [i];
        if (array [i] < min) min = array [i];
    }
    return (max - min);
}

Console.WriteLine ("Enter array size");
int size = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter array max");
double max = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine ("Enter array min");
double min = Convert.ToDouble (Console.ReadLine ());
double [] array = CreateArrayDouble (size, min, max);
PrintArray (array);
Console.WriteLine ();
double difference = FindDiffMaxMin (array);
Console.WriteLine ($"Difference between max and min is {difference}");
