/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*Console.WriteLine("Введите число");
string userNumber = Console.ReadLine();
char[] numberArray = userNumber.ToCharArray();
Console.WriteLine(numberArray);
Console.WriteLine(numberArray.Length);
int sum = 0;
for (int i = 0; i < numberArray.Length; i++)
{
        sum += numberArray[i];
}
Console.WriteLine($"Сумма цифр в числе {userNumber} равна {sum}");
*/

int getGetSumOfDigits(int number)
{
    int divResult = number;
    int lastDigit = new int();
    int sumOfDigits = 0;
    while (divResult > 0)
    {
        lastDigit = divResult % 10;
        sumOfDigits += lastDigit;
        divResult = divResult / 10;
    }
    return sumOfDigits;
}
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumResult = getGetSumOfDigits(userNumber);
Console.WriteLine($"Сумма цифр числа {userNumber} равна {sumResult}");

