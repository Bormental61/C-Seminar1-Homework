/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateMatrix(int height, int width, int deviation)
{
    int[,] generatedMatrix = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedMatrix[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return generatedMatrix;
}
void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void ShowMatrix(int[,] inputMatrix)
{
    PrintColorData($" \t");
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        PrintColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        PrintColorData($"{i}\t");
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int FindMinSumRowNumber(int[,] inputMatrix)
{
    int minRowSum = new int();
    int minSumRowNumber = 1;
    int rowSum = new int();
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        minRowSum += inputMatrix[0, i];
    }
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            rowSum += inputMatrix[i, j];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minSumRowNumber = i + 1;
        }
        rowSum = 0;
    }
    return minSumRowNumber;
}

int[,] generatedMatrix = GenerateMatrix(5, 5, 10);
ShowMatrix(generatedMatrix);
int numberOfRowWithMinimalSum = FindMinSumRowNumber(generatedMatrix);
Console.WriteLine($"{numberOfRowWithMinimalSum} строка имеет минимальную сумму элементов.");