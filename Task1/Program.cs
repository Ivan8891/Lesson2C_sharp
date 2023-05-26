// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 1000)
	{
	number %= 100;
	number /= 10;
	Console.WriteLine($"Вторая цифра {number}.");
	}
else
	{
	Console.WriteLine($"Число {number} не трехзначное.");
	}
