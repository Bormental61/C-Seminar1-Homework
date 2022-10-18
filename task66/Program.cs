/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите начальное значение M");
int userNumberStart = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное значение N");
int userNumberEnd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSumOfElements(userNumberStart, userNumberEnd));



int GetSumOfElements(int start, int end)
{
    int sum = start;
    if (start > end)
    {
        return 0;
    }
    sum = start + GetSumOfElements(start + 1, end);
    return sum;
}
