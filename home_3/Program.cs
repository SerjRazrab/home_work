// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), //
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.//
Console.WriteLine("Введите координаты точки (X и Y):");
int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);
if ((X > 0)&&(Y > 0))
{
    Console.WriteLine("Точка координат лежит в 1 четверти");
}
else if ((X> 0)&&(Y < 0))
{
    Console.WriteLine("Точка координат лежит во 4-ой четверти");
}
else if ((X < 0)&&(Y > 0))
{
    Console.WriteLine("Точка координат лежит во 2-ой четверти");
}
else if ((X < 0)&&(Y < 0))
{
    Console.WriteLine("Точка координат лежит во 3-ей четверти");
}
else 
{
    Console.WriteLine("Exit");
}