/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

void PrintInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int GetNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            PrintInConsoleWithColor($"Введите целое число, вы ввели {userLine}", ConsoleColor.Red);
        }
        else
        {
            break;
        }
    }
    return result;
}

int[] GetArrayFromUser(int length)
{
    int[] userArray = new int[length];
    userArray[0] = GetNumberFromUser("Введите первое число массива: ");
    for (int i = 1; i < length; i++)
    {
        userArray[i] = GetNumberFromUser("Введите следующее число массива: ");
    }
    return userArray;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int CountPositiveArrayNumbers(int[] incomingArray)
{
    int count = new int();
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Привет! Эта программа считает сколько чисел больше 0 Вы ввели.");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    int userArrayLength = GetNumberFromUser("Введите какое количество чисел мы будем проверять: ");
    if (userArrayLength == 0)
    {
        Console.WriteLine("Введите количество больше 0!");
        userArrayLength = GetNumberFromUser("Введите какое количество чисел мы будем проверять: ");
    }
    int[] userArray = GetArrayFromUser(userArrayLength);
    Console.WriteLine("Вы ввели следующие числа:");
    printArray(userArray);
    int positiveCount = CountPositiveArrayNumbers(userArray);
    Console.WriteLine($"{positiveCount} из введенных Вами чисел больше 0");

    Console.WriteLine("Хотите повторить? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста введите верное решение. Да - Y, Нет - N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Пока!");