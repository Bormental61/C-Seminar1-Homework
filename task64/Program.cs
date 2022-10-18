/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число N");
int userNumber = Convert.ToInt32(Console.ReadLine());
PrintRange(userNumber);

void PrintRange(int N)
{
    if (N == 0)
    {
        return;
    }
    if (N != 1)
    {
    Console.Write($"{N}, ");
    }
    else
    {
        Console.WriteLine($"{N}");
    }
    PrintRange(N - 1);
}


