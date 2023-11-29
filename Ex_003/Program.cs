/* Задайте массив на 10 целых чисел. 
Напишите программу, которая определяет количество чётных чисел в массиве. */

int [] CreateArray (int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (min, max + 1);
    }
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }
}

int CountEven (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0) count++;
    }
    return count; 
}

Console.WriteLine ("Enter array min");
int min = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter array max");
int max = Convert.ToInt32 (Console.ReadLine ());
int [] array = CreateArray (10, min, max);
ShowArray (array);
Console.WriteLine ();
int count = CountEven (array);
Console.WriteLine ($"The amount of even numbers is {count}");
