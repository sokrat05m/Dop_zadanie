/* Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива. 
Под удалением понимается создание нового двумерного массива без строки и столбца */

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

int [,] ArrayWithoutMin (int [,] array){
    int [,] newArray = new int [array.GetLength (0) - 1, array.GetLength (1) - 1];
    int i = 0;
    int j = 0;
    int iMin = i;
    int jMin = j;
    int min = array [i, j];
    for (i = 0; i < array.GetLength (0); i++){
        for (j = 0; j < array.GetLength (1); j++){
            if (array [i, j] < min){
                min = array [i, j];
                iMin = i;
                jMin = j;
            }
        }
    }
    int m = 0;
    int n = 0;
    for (i = 0; i < array.GetLength (0) ; i++){
        if (i != iMin){
            n = 0;
            for (j = 0; j < array.GetLength (1); j++){
                    if (j != jMin){
                    newArray [m, n] = array [i, j];
                   n++;
                }  
            }
            m++;
        }
        
    }
    return newArray;
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
int [,] newArray = ArrayWithoutMin (array);
Show2dArray (newArray);
