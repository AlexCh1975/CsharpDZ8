/*
    Задача 62(). Напишите программу, которая заполнит спирально массив 
    4 на 4. ( - необязательная)
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/

Console.Clear();

int[,] array = CreateArray();
PrintArray(array);

int[,] CreateArray()
{
    int[,] array = new int[4,4];
    int rows = 4;
    int columns = 4;

    int count = 1;
    int i = 0;
    int j = 0;
    for (; j < columns; j++)
    {
        array[i,j] = count;
        count++;
    }
   
    j = columns - 1;
    for (i = rows - 3; i <= rows - 1; i++)
    {
        array[i,j] = count;
        count++;
    }
    i = rows - 1;
    for (j = columns - 2; j >= 0; j--)
    {
        array[i,j] = count;
        count++;
    }
    j = 0;
    for (i = rows - 2; i >= rows - 3; i--)
    {
        array[i,j] = count;
        count++;
    }
    i = rows - 3;
    for (j = columns - 3; j <= columns - 2; j++)
    {
        array[i,j] = count;
        count++;
    }
    j = columns - 2; 
    for (i = rows - 2; i <= rows - 2; i++)
    {
        array[i,j] = count;
        count++;
    }
    i = rows - 2;
    for (j = columns - 3; j >= columns - 3; j--)
    {
        array[i,j] = count;
        count++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Green;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            {
                string result = Convert.ToString(array[i,j]);
                result = "0" + result;
                Console.Write($"\t{result}");
            }
            else
            {
                string result = Convert.ToString(array[i,j]);
                Console.Write($"\t{result}");
            }
        }
        Console.WriteLine();
    }

    Console.ResetColor();
}