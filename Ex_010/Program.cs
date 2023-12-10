/* Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы. */

int [] CreateArray (int size)
{
    int [] array = new int [size];
    return array;
}

void FillArray (int [] array, int min, int max, int i){
    array [i] = new Random().Next (min, max + 1);
    if (i == array.Length - 1) return;
    FillArray (array, min, max, i + 1);
}

void ShowArray (int [] array, int i)
{
    Console.Write ($"{array [i]} ");
    if (i == (array.Length - 1)){
        return;
    } 
    ShowArray (array, (i + 1));
} 

void SortArray (int [] array, int i){
    Console.Write ($"{array [i]} ");
    if (i == 0) Console.WriteLine ();
    else SortArray (array, i - 1);
}

Console.WriteLine ("Enter array size");
int size = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter array max");
int max = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter array min");
int min = Convert.ToInt32 (Console.ReadLine ());
int topIndex = size - 1;
int [] array = CreateArray (size);
FillArray (array, min, max, 0);
ShowArray (array, 0);
Console.WriteLine ();
SortArray (array, topIndex);
