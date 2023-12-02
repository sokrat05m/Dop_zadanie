/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random ().Next (min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int [] SmallRowArray (int [,] array){
    int sum = 0;
    int min = 0;
    for (int j = 0; j < array.GetLength (1); j++){
        min = min + array [0, j];
    }
    int iLowest = 0;
    for (int i = 0; i < array.GetLength (0); i++){
        for (int j = 0; j < array.GetLength (1); j++){
            sum = sum + array [i, j];
        }
        if (sum < min){
            min = sum;
            iLowest = i;
        }
        sum = 0;
    }
    int [] newArray = new int [array.GetLength (1)];
    int k = 0;
    for (int j = 0; j < array.GetLength (1); j++){
        newArray [k] = array [iLowest, j];
        k++;
    }
    return newArray;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }
}

Console.WriteLine ("Задайте минимально возможное число массива");
int min = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Задайте максимально возможное число массива");
int max = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Задайте количество строк массива");
int row = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Задайте количество столбцов массива");
int col = Convert.ToInt32 (Console.ReadLine ());
int [,] array = Create2dArray (row, col, min, max);
Show2dArray (array);
Console.WriteLine ();
int [] arrayLittle = SmallRowArray (array);
PrintArray (arrayLittle);
