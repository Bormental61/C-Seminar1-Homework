/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getArrayLengthFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 0)
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
int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int getCountOfPositiveNumbersInArray(int[] incomingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int userArrayLength = getArrayLengthFromUser("");
int[] randomArrayUserLength = getRandomArray(userArrayLength, 100, 999);
printArray(randomArrayUserLength);
int countOfPositiveNumbersInArray = getCountOfPositiveNumbersInArray(randomArrayUserLength);
Console.WriteLine($"В этом массиве {countOfPositiveNumbersInArray} четных чисел.");








