/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы. */

void ShowNumbersBetween (int m, int n){
    if (m > n ) return;
    else if (m <= n){
        Console.Write ($"{m} ");
    }
    ShowNumbersBetween (m + 1, n);
}
Console.WriteLine ("Введите число M");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число N");
int n = Convert.ToInt32 (Console.ReadLine ());
if (m > n) Console.WriteLine ("Число M не может быть больше числа N");
else ShowNumbersBetween (m, n);
