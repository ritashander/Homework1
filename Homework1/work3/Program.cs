// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)

Console.WriteLine("Введите число");
if(int.Parse(Console.ReadLine()) % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}