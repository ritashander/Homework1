// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

for (int i = m; i <= n; i++)
    {
        if (i % 2 == 0) 
        {
                Console.Write(i + " ");
        }
    }


