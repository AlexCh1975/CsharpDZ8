/*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int[,] twoDimensionalArray = CreateTwoDimensionalArray();
int[] sumArray = GetSumArrayRows(twoDimensionalArray);
int indexMinSumArrayRows = GetMinSumArrayRows(sumArray);
PrintTwoDimensionalArray(twoDimensionalArray, indexMinSumArrayRows);

int[,] CreateTwoDimensionalArray()
{
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[] GetSumArrayRows(int[,] array)
{
    int rows = 4;
    int columns = 4;
    int[] newArray = new int[rows];

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i,j];
        }
        newArray[i] = sum;
    }
    return newArray;
}

int GetMinSumArrayRows(int[] array)
{
    int minSumArrayRows = array[0];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSumArrayRows) 
        {
            minSumArrayRows = array[i];
            index = i;
        }
    }
    return index +1; 
} 

void PrintTwoDimensionalArray(int[,] array, int indexMinSumArrayRows)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"\t{array[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("]");
    Console.WriteLine($"Строка с минимальной суммой: {indexMinSumArrayRows}");
    Console.ResetColor();
}