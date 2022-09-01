/*
    Задача 54: Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
*/

Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] twoDimensionalArray = CreateTwoDimensionalArray(rows, columns);
int[,] newtTwoDimensionalArray = CreateNewTwoDimensionalArray(twoDimensionalArray);
PrintTwoDimensionalArray(twoDimensionalArray, newtTwoDimensionalArray);

int[,] CreateTwoDimensionalArray(int rows, int columns)
{
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

int[,] CreateNewTwoDimensionalArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int[,] newArray = new int[rows, columns];
    int[] arr = new int[columns];

    int[] SortDescendingOrderArrayRows(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        
        return array;
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[j] = array[i, j];
        }
        arr = SortDescendingOrderArrayRows(arr);
      
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = arr[j];
        }
    }
    return newArray;
}

void PrintTwoDimensionalArray(int[,] array, int[,] newArray)
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
    Console.ResetColor();

    int newRows = newArray.GetUpperBound(0) + 1;
    int newColumns = newArray.Length / rows;

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("[");

    for (int i = 0; i < newRows; i++)
    {
        for (int j = 0; j < newColumns; j++)
        {
            Console.Write($"\t{newArray[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("]");
    Console.ResetColor();
}
