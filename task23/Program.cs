/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

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
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}
Console.Write("Введите целое число больше 0: ");
int userNumber = getNumberFromUser(" ");
int squareNumber = 1;
while (squareNumber <= userNumber)
{
    Console.Write($"{Math.Pow(squareNumber, 3)} ");
    squareNumber++;
}
