/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numberTwo = number  % 100 / 10;   //   Или "NUMBER / 10 % 10"
if ((number < 100) || (number >= 1000))
{
    Console.WriteLine("Число не трёхзначное. Введите трёхзначное число");
    return;
}
Console.WriteLine($"Введено число: {number}");
Console.WriteLine($"Второе число: {numberTwo}");
