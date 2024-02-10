/* Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы/
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RecArr(myArr,myArr.Length - 1);
    }

    static void RecArr(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            RecArr(arr, index - 1);
        }

    }
}