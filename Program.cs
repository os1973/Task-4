﻿/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string first = Console.ReadLine();
int firstnumber - int.Parse(first);
Console.WriteLine("Введите второе число");
string second = Console.ReadLine();
int secondnumber - int.Parse(second);
Console.WriteLine("Введите третье число");
string third = Console.ReadLine();
int thirdnumber - int.Parse(third);
int max;
if(firstnumber > secondnumber && firstnumber > thirdnumber)
{
    max = firstnumber;
}
else if(secondnumber > firstnumber && secondnumber >thirdnumber)
{
    max = secondnumber;
}
else if(thirdnumber > firstnumber && thirdnumber >secondnumber)
{
    max = thirdnumber;
}
 