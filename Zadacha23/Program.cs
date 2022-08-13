// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using static System.Console;
Clear();
WriteLine("Введите число: ");
int n = Convert.ToInt32(ReadLine());
int i = 1;
while(i <= n)
{
    Write(i*i*i + " ");
    i++;
}