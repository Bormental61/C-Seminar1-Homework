/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
double[] GetColumnsArithMean(int[,] intakeArray)
{
    double[] arithMeanArray = new double[intakeArray.GetLength(1)];
    double sumOfColumn = new int();
    for (int j = 0; j < intakeArray.GetLength(1); j++)
    {
        for (int i = 0; i < intakeArray.GetLength(0); i++)
        {
            sumOfColumn += intakeArray[i, j];
        }
        arithMeanArray[j] = Math.Round(sumOfColumn / intakeArray.GetLength(0), 1);
        sumOfColumn = 0;
    }
    return arithMeanArray;
}
void PrintArithMeanArray(double[] inArithMeanArray)
{
    for (int i = 0; i < inArithMeanArray.Length - 1; i++)
    {
        Console.Write($"{inArithMeanArray[i]}, ");
    }
    Console.Write(inArithMeanArray[inArithMeanArray.Length - 1]);
}
int[,] newGeneratedArray = Generate2DArray(3, 4, 1, 9);
Print2DArray(newGeneratedArray);
double[] ColumnsArithMean = GetColumnsArithMean(newGeneratedArray);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArithMeanArray(ColumnsArithMean);