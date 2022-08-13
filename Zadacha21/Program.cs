// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();

WriteLine("Введите координаты точки А :");
double x1 = Convert.ToDouble(ReadLine());
double y1 = Convert.ToDouble(ReadLine());
double z1 = Convert.ToDouble(ReadLine());
WriteLine("Введите координаты точки B :");
double x2 = Convert.ToDouble(ReadLine());
double y2 = Convert.ToDouble(ReadLine());
double z2 = Convert.ToDouble(ReadLine());
double result = Convert.ToDouble(Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1)));
WriteLine($"Расстояние между двумя точками равно : {result:f2}");