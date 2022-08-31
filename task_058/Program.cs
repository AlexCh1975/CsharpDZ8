/*
    Задача 58: Задайте две матрицы. Напишите программу, 
    которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
*/

Console.Clear();

int[,] matrixA = CreateMatrix();
int[,] matrixB = CreateMatrix();

int[,] matrixC = GetMatrixProduct(matrixA, matrixB);
PrintMatrix(matrixA, matrixB, matrixC);

int[,] CreateMatrix()
{
    int rows = 2;
    int columns = 2;
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

int[,] GetMatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int rows = matrixA.GetLength(0);
    int columns = matrixA.GetLength(1);
    int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(1)];


    matrixC[0,0] =  matrixA[0,0] * matrixB[0,0] + matrixA[0,1] * matrixB[1,0];
    
    matrixC[0,1] =  matrixA[0,0] * matrixB[0,1] + matrixA[0,1] * matrixB[1,1];
   
    matrixC[1,0] =  matrixA[1,0] * matrixB[0,0] + matrixA[1,1] * matrixB[1,0];
   
    matrixC[1,1] =  matrixA[1,0] * matrixB[0,1] + matrixA[1,1] * matrixB[1,1];
    

    return matrixC;
}

void PrintMatrix(int[,] matrixA, int[,] matrixB, int[,]matrixC)
{
    int rows = matrixA.GetUpperBound(0) + 1;
    int columns = matrixB.Length / rows;

    Console.ForegroundColor = ConsoleColor.Green;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"  {matrixA[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"  {matrixB[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"  {matrixC[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.ResetColor();
}