/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getArrayParametersFromUser(string userInformation)
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
int getSumOfOddIndexNumbers(int[] incomingArray)
{
    int resultSum = incomingArray[0];
    for (int i = 1; i < incomingArray.Length; i++)
    {
        if (i % 2 == 0)
        {
            resultSum += incomingArray[i];
        }
    }
    return resultSum;
}
Console.WriteLine("Введите размер массива: ");
int userArrayLength = Math.Abs(getArrayParametersFromUser(""));
Console.WriteLine("Введите нижнюю границу чисел массива: ");
int userArrayStartBorder = getArrayParametersFromUser("");
Console.WriteLine("Введите верхнюю границу чисел массива: ");
int userArrayEndBorder = getArrayParametersFromUser("");
int[] randomArray = getRandomArray(userArrayLength, userArrayStartBorder, userArrayEndBorder);
printArray(randomArray);
int sumOfOddIndexNumbers = getSumOfOddIndexNumbers(randomArray);
Console.WriteLine($"Сумма элементов на нечетной позиции (с четным индексом) равна {sumOfOddIndexNumbers}");
