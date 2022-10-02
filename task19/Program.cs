/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int getNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0 || result < 10000 || result > 99999)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое пятизначное число, вы ввели {userLine}");
        }
        else if (result < 10000 || result > 99999)
        {
            Console.WriteLine($"Введите целое пятизначное число, вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}
Console.Write("Введите целое пятизначное число: ");
int userNumber = getNumberFromUser("");
int lastDigit = userNumber;
int[] array = new int[5];
array[4] = lastDigit % 10;
lastDigit = lastDigit / 10;
array[3] = lastDigit % 10;
lastDigit = lastDigit / 10;
array[2] = lastDigit % 10;
lastDigit = lastDigit / 10;
array[1] = lastDigit % 10;
lastDigit = lastDigit / 10;
array[0] = lastDigit % 10;
if (array[4] == array[0] && array[3] == array[1])
{
    Console.Write($"Число {userNumber} является палиндромом");
}
else
{
    Console.Write($"Число {userNumber} не является палиндромом");
}