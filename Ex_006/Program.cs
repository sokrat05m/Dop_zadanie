/*  Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива. */

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

int [,] ChangeRows (int [,] array){
    int [] arrayTemp = new int [array.GetLength (1)];
    int i = 0;
    int k = 0;
    
    for (int j = 0; j < array.GetLength (1); j++){
        arrayTemp [k]= array [i, j];
        k++;
    }
    k = 0;
    for (int j = 0; j < array.GetLength (1); j++){
        array [i, j] = array [array.GetLength(0) - 1, j];
    }
    for (int j = 0; j < array.GetLength (1); j++){
        array [array.GetLength(0) - 1, j] = arrayTemp [k];
        k++;
    }
    return array;
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
int [,] arrayChanged = ChangeRows (array);
Show2dArray (arrayChanged);
