// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.WriteLine("Введите три числа");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное число:");
Console.WriteLine(Math.Max(n1, Math.Max(n2, n3)));