/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int getSecondDigitFromThreeDigitNumber(int number)
{
    int deciNumber = number/10;
    int secondDigit = deciNumber % 10;
    return secondDigit;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = getSecondDigitFromThreeDigitNumber(number);
Console.WriteLine($"Вторая цифра числа {number} - {secondDigit}");