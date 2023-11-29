/* Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, значения которых лежат в отрезке [20,90] */

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

int CountNumber (int [] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] >= min && array [i] <= max) count++;
    }
    return count; 
}

int size = 10;
int min = 1;
int max = 100;
int minSearch = 20;
int maxSearch = 90;
int [] array = CreateArray (size, min, max);
ShowArray (array);
Console.WriteLine ();
int count = CountNumber (array, minSearch, maxSearch);
Console.WriteLine ($"Количество чисел на отрезке [20; 90] в массиве равно {count}");
