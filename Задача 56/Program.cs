/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

void SummElementsRow(int[,] matrix)
{
    int summ = int.MaxValue;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count += matrix[i, j];

        }
        if (count < summ)
        {
            summ = count;
            index = i + 1;

        }
    }
    Console.WriteLine($"сумма элементов строки {index} наименьшая из всех и равна: {summ} ");
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

int row = GetNumber("Введите колличество строк и столбцов: ");
int column = row;
int[,] matrix = InitArray(row, column);
PrintMatrix(matrix);
SummElementsRow(matrix);