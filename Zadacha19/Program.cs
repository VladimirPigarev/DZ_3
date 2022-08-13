// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using static System.Console;
Clear();
WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(ReadLine());
int number2 = 0;
int number1 = n;
while(n > 0) // переворачиваем число
{
    int digit = n % 10;
    number2 = number2 * 10 + digit;
    n = n / 10;
}
if(number1 == number2) // сравниваем с исходным числом и определям является ли оно палиндромом
{
    WriteLine($"{number1} + {number2} это палиндром");
}
else
{
    WriteLine($"{number1} + {number2} это не палиндром");
}