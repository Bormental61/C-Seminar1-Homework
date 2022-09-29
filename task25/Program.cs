/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();    
}    
int Pow(int number, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result *= number;
    }
    return result;
}
int getNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            printInConsoleWithColor($"Введите целое число, вы ввели {userLine}", ConsoleColor.Red);
        }
        else
        {
            break;
        }
    }
    return result;
}
Console.WriteLine("Здравствуйте, эта программа возводит число А в степень В");
Console.Write("Введите число А: ");
int userNumber = getNumberFromUser("");
Console.Write("Введите число В: ");
int userPow = getNumberFromUser("");
int powNumber = Pow(userNumber, userPow);
Console.WriteLine($"Число {userNumber} в степени {userPow} равняется {powNumber}.");

