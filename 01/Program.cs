/*
 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое число");
string numberAstr = Console.ReadLine();
int numberA = Convert.ToInt32(numberAstr);

Console.WriteLine("Введите второе число");
string numberBstr = Console.ReadLine();
int numberB = Convert.ToInt32(numberBstr);

int max = numberB;

if (numberA > numberB)

max = numberA;
Console.WriteLine("Большее число:");
Console.WriteLine(max);