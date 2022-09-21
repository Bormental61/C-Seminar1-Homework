/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int getThirdDigit(int number)
{
    int divResult = number;
    int count = 0;
    int thirdDigit = -1;
    while (divResult > 0)
    {
        divResult = divResult / 10;
        count++;
    }
    if (count > 2)
    {
        int pow10 = Convert.ToInt32(Math.Pow(10, count - 3));
        int ThreeDigitNumber = number / pow10;
        thirdDigit = ThreeDigitNumber % 10;
    }
        return thirdDigit;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdDigit = getThirdDigit(number);
if (ThirdDigit == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {number} -> {ThirdDigit}");
}

