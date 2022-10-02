/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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
double[] getRandomArray(int length, int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1) + new Random().NextDouble();
    }
    return resultArray;
}
void printArray(double[] incomingArray)
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
double getMaxNumbersOfArray(double[] incomingArray)
{
    double maxNumber = incomingArray[0];
    for (int i = 1; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > maxNumber)
        {
            maxNumber = incomingArray[i];
        }
    }
    return maxNumber;
}
double getMinNumbersOfArray(double[] incomingArray) 
{
    double minNumber = incomingArray[0]; 
    for (int i = 1; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] < minNumber)
        {
            minNumber = incomingArray[i];
        }
    }
    return minNumber;
}
    
Console.WriteLine("Введите размер массива: ");
int userArrayLength = Math.Abs(getArrayParametersFromUser(""));
Console.WriteLine("Введите нижнюю границу чисел массива: ");
int userArrayStartBorder = getArrayParametersFromUser("");
Console.WriteLine("Введите верхнюю границу чисел массива: ");
int userArrayEndBorder = getArrayParametersFromUser("");
double[] randomArray = getRandomArray(userArrayLength, userArrayStartBorder, userArrayEndBorder);
Console.WriteLine("Массив случайных вещественных чисел по заданным параметрам:");
printArray(randomArray);
double Max = getMaxNumbersOfArray(randomArray);
Console.WriteLine($"Максимальное вещественное число в массиве {Max}");
double Min = getMinNumbersOfArray(randomArray);
Console.WriteLine($"Минимальное вещественное число в массиве {Min}");
double diff = Max - Min;
Console.WriteLine($"Разница между максимальным и минимальным вещественными числами в массиве равна {diff}");


