/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

string ifHolyday (int number)
{
    string result = "";
    if (number > 5)
    {
        result = "выходной";
    }
    else
    {
        result = "рабочий";
    }
    return result;
}
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
string holydayOrNot = ifHolyday(number);
if (number > 0 && number < 8) 
{
    Console.WriteLine($"День {number} -> {holydayOrNot}");
}
else 
{
    Console.WriteLine("В неделе 7 дней");
}