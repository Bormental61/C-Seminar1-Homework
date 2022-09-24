/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double getDistance(int coordinateAX, int coordinateAY, int coordinateAZ, int coordinateBX, int coordinateBY, int coordinateBZ)
{
    double result = new int();
    result = Math.Sqrt(Math.Pow((coordinateAX - coordinateBX), 2) + Math.Pow((coordinateAY - coordinateBY), 2) + Math.Pow((coordinateAZ - coordinateBZ), 2));
    return result;
}

int getCoordinateFromUser(string userInformation)
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

int userCoordinateAX = 0;
int userCoordinateAY = 0;
int userCoordinateAZ = 0;
int userCoordinateBX = 0;
int userCoordinateBY = 0;
int userCoordinateBZ = 0;
Console.WriteLine("Введите координаты");
userCoordinateAX = getCoordinateFromUser("Введите координату X точки А: ");
userCoordinateAY = getCoordinateFromUser("Введите координату Y точки А: ");
userCoordinateAZ = getCoordinateFromUser("Введите координату Z точки А: ");
userCoordinateBX = getCoordinateFromUser("Введите координату X точки B: ");
userCoordinateBY = getCoordinateFromUser("Введите координату Y точки B: ");
userCoordinateBZ = getCoordinateFromUser("Введите координату Z точки B: ");
double distance = getDistance(userCoordinateAX, userCoordinateAY, userCoordinateAZ, userCoordinateBX, userCoordinateBY, userCoordinateBZ);
Console.WriteLine($"Расстояние между точкой А [{userCoordinateAX}:{userCoordinateAY}:{userCoordinateAZ}] и точкой B [{userCoordinateBX}:{userCoordinateBY}:{userCoordinateBZ}] равно {distance}");