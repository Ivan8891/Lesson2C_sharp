// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100)
	{	
	while (number > 1000)
		{
		number /= 10;
		}
	number %=10;
	Console.WriteLine($"Третье число {number}");
	}
else
	{
	Console.WriteLine("В этом числе нет третей цифры.");
	}
