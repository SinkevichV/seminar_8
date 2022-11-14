/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");

    return result;
}

int[,] InitArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = rnd.Next(0, 10);
        }
    }
    return newArray;
}

void PrintMatrix(int[,] matrix)
{
    Console.Write("\r\n");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.Write("\r\n");
}

int[,] MultiMatrix(int[,] matrixFirst, int[,] matrixSecond, int rowFirstMatrix, int columnFirstMatrix, int rowSecondMatrix, int columnSecondMatrix)
{
    int[,] matrixMulti = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    if (matrixFirst.GetLength(1) != matrixSecond.GetLength(0))
    {
        Console.WriteLine("Матрицы перемножить нельзя");
    }
    else
    {
        for (int i = 0; i < matrixFirst.GetLength(0); i++)
        {
            for (int j = 0; j < matrixSecond.GetLength(1); j++)
            {
                for (int k = 0; k < matrixSecond.GetLength(0); k++)
                {
                    matrixMulti[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
                }
            }
        }

    }
    return matrixMulti; ;
}

int rowFirstMatrix = GetNumber("Введите колличество строк первой матрицы: ");
int columnFirstMatrix = GetNumber("Введите колличество столбцов первой матрицы: ");
int rowSecondMatrix = GetNumber("Введите колличество строк второй матрицы: ");
int columnSecondMatrix = GetNumber("Введите колличество столбцов матрицы: ");
int[,] matrixFirst = InitArray(rowFirstMatrix, columnFirstMatrix);
int[,] matrixSecond = InitArray(rowSecondMatrix, columnSecondMatrix);

PrintMatrix(matrixFirst);
PrintMatrix(matrixSecond);
int[,] matrixResult = MultiMatrix(matrixFirst, matrixSecond, rowFirstMatrix, columnFirstMatrix, rowSecondMatrix, columnSecondMatrix);
MultiMatrix(matrixFirst, matrixSecond, rowFirstMatrix, columnFirstMatrix, rowSecondMatrix, columnSecondMatrix);
PrintMatrix(matrixResult);