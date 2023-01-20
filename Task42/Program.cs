﻿/* 42. Напишите программу, которая будет преобразовывать
десятичное число в двоичное. 45 -> 101101, 2 -> 10.   */
int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
string TransformBinary(int number)
{
    string result = String.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    return result;
}
int number = getUserData("Введите число");
string binary = TransformBinary(number);
Console.WriteLine($"Число {number} в двоичной системе = {binary}");
