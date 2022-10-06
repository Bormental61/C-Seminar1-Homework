/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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

Console.Clear();
Console.WriteLine("Привет! Эта программа, находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    double b1 = GetNumberFromUser("Введите переменную b1 для первой прямой: ");
    double k1 = GetNumberFromUser("Введите переменную k1 для первой прямой: ");
    double b2 = GetNumberFromUser("Введите переменную b2 для второй прямой: ");
    double k2 = GetNumberFromUser("Введите переменную k2 для второй прямой: ");
    double commonX = (b2 - b1)/(k1 - k2);
    double commonY = k1 * commonX + b1;
    Console.WriteLine($"Точка пересечения заданных прямых имеет координаты [{commonX}; {commonY}]");
    
    Console.WriteLine("Хотите повторить? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста введите верное решение. Да - Y, Нет - N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Пока!");