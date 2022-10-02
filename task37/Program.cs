/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
int[] getOppozitCoupleMultiplyArrayFromFirstArray(int[] incomingArray)
{
    int resultArrayLength = new int();
    if (incomingArray.Length % 2 == 0)
    {
        resultArrayLength = incomingArray.Length / 2;
    }
    else
    {
        resultArrayLength = incomingArray.Length / 2 + 1;
    }
    int[] resultArray = new int[resultArrayLength];
    int lastNumberIndex = incomingArray.Length - 1;
    if (incomingArray.Length % 2 == 0)
    {
        for (int i = 0; i < resultArray.Length; i++)
        {
            resultArray[i] = incomingArray[i] * incomingArray[lastNumberIndex];
            lastNumberIndex--;
        }
    }
    else
    {
        for (int i = 0; i < resultArray.Length; i++)
        {
            resultArray[i] = incomingArray[i] * incomingArray[lastNumberIndex];
            lastNumberIndex--;
            resultArray[resultArray.Length - 1] = incomingArray[resultArray.Length - 1];
        }
    }
    return resultArray;
}

Console.Clear();
Console.WriteLine("Привет! Эта программа создает массив заданного размера и заполняет его случайными чиселами в заданном диапазоне,");
Console.WriteLine("а затем создает новый массив, элементы которого являются попарными произведениями");
Console.WriteLine("первого и последнего элемента,");
Console.WriteLine("второго и предпоследнего и т.д.");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    Console.Write("Введите размер массива: ");
    int userArrayLength = Math.Abs(getArrayParametersFromUser(""));
    Console.WriteLine("Введите нижнюю границу чисел массива: ");
    int userArrayStartBorder = getArrayParametersFromUser("");
    Console.WriteLine("Введите верхнюю границу чисел массива: ");
    int userArrayEndBorder = getArrayParametersFromUser("");
    int[] randomArray = getRandomArray(userArrayLength, userArrayStartBorder, userArrayEndBorder);
    printArray(randomArray);
    int[] oppozitCoupleMultiplyArrayFromFirstArray = getOppozitCoupleMultiplyArrayFromFirstArray(randomArray);
    printArray(oppozitCoupleMultiplyArrayFromFirstArray);

    Console.WriteLine("Хотите повторить? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        printInConsoleWithColor("Пожалуйста, введите верный символ.", ConsoleColor.Red); 
        printInConsoleWithColor("Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N", ConsoleColor.Red);
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");
