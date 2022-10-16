/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortRowsDown(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(1) - 1; k++)
            {
                if (inputMatrix[i, k] < inputMatrix[i, k + 1])
                {
                    int temp = inputMatrix[i, k + 1];
                    inputMatrix[i, k + 1] = inputMatrix[i, k];
                    inputMatrix[i, k] = temp;
                }
            }
        }
    }
}

int[,] generatedMatrix = GenerateMatrix(5, 5, 10);
ShowMatrix(generatedMatrix);
Console.WriteLine();
SortRowsDown(generatedMatrix);
ShowMatrix(generatedMatrix);