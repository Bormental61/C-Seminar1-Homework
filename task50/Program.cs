/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9

индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
*/

int[,] Generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}
void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void Print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        PrintColorData(i + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        PrintColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
// int[] Convert2DArrayToArray(int[,] arrayToConvert)
// {
//     int[] singleArray = new int[arrayToConvert.GetLength(0) * arrayToConvert.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < arrayToConvert.GetLength(0); i++)
//         for (int j = 0; j < arrayToConvert.GetLength(1); j++)
//         {
//             singleArray[i] = arrayToConvert[i, j];
//         }
//         return singleArray;            
// }
int[,] newGeneratedArray = Generate2DArray(3, 4, 0, 9);
Print2DArray(newGeneratedArray);
Mark:
Console.Write("Введите порядковый номер элемента в двухмерном массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > newGeneratedArray.GetLength(0) * newGeneratedArray.GetLength(1) - 1)
{
    Console.WriteLine($"{number} -> такого числа в массиве нет");
    goto Mark;
}
else
{
    int row = number / newGeneratedArray.GetLength(1);
    int column = number % newGeneratedArray.GetLength(1);
    Console.WriteLine($"на позиции {number} в массиве находится элемент {newGeneratedArray[row, column]}");
}
