/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getArrayLenghsFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0)
        {
            printInConsoleWithColor($"Введите количество символов в массиве, вы ввели {userLine}", ConsoleColor.Red);
        }
        else
        {
            break;
        }
    }
    return result;
}
int randomNumber(int min, int max)
{
    int num = new Random().Next(min, max + 1);
    return num;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

Console.Clear();
Console.WriteLine("Привет! Эта программа создает массив случайных элементов в диапазоне от 1 до 99 заданной Вами длины.");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    Console.Write("Введите длину массива: ");
    int userArrayLenghs = getArrayLenghsFromUser("");
    int[] randomArray = new int[userArrayLenghs];
    for (int i = 0; i < userArrayLenghs; i++)
    {
        randomArray[i] = randomNumber(1, 99);
    }
    printArray(randomArray);

    Console.WriteLine("Хотите повторить? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верный символ. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");
