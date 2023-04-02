// Homework #1

// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Число " + num1 + " больше числа " + num2);
}
else
{
    Console.WriteLine("Число " + num2 + " больше числа " + num1);
}
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 & num1 > num3)
{
    Console.WriteLine($"Максимальное число {num1}");
}
else if (num2 > num1 & num2 > num3)
{
    Console.WriteLine($"Максимальное чмсло {num2}");
}
else
{
    Console.WriteLine($"Максимальное число {num3}");
}
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}
*/

// Задача 4.  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= num; i = i + 2)
{
    Console.WriteLine(i);
}
*/