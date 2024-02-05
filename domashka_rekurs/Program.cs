// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите значение M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N : ");
int n = Convert.ToInt32(Console.ReadLine());
void rec(int m,int n)
{
    if (m > n)
        return;
    if (m != 0)
    {
        Console.Write($"{m} ");
    }
    rec(m + 1, n);
}
rec(m,n);


