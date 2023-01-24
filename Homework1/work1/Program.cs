// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine("Большее:");
    Console.WriteLine(number1);
    Console.WriteLine("Меньшее:");
    Console.WriteLine(number2);
}
else if (number1 < number2)
{
    Console.WriteLine("Меньшее:");
    Console.WriteLine(number1);
    Console.WriteLine("Большее:");
    Console.WriteLine(number2);
}
