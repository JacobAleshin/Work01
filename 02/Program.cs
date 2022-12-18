/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string numberAstr = Console.ReadLine();
int numberA = Convert.ToInt32(numberAstr);


Console.WriteLine("Введите второе число");
string numberBstr = Console.ReadLine();
int numberB = Convert.ToInt32(numberBstr);


Console.WriteLine("Введите первое число");
string numberCstr = Console.ReadLine();
int numberC = Convert.ToInt32(numberCstr);


int max = numberA;


if (numberB > max)
    max = numberB;
 
if (numberC > max)
    max = numberC;
  

Console.WriteLine("Максимальное из трёх чисел:");
Console.WriteLine(max);