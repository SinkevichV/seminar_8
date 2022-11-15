// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

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

int[,,] InitArray(int x, int y, int z)
{
    int[,,] newArray = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                bool contains;
                int next;
                do
                {
                    next = rnd.Next(10, 100);
                    contains = false;
                    int n = newArray[i, j, k];
                    if (n == next)
                    {
                        contains = true;
                        break;
                    }

                }
                while (contains);
                newArray[i, j, k] = next;
            }

        }

    }
    foreach (int i in newArray) ;
    return newArray;
}



void PrintMatrix(int[,,] matrix)
{
    Console.Write("\r\n");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} с индексами ({i};{j};{k}) ");
            }

        }
        Console.WriteLine();
    }
    Console.Write("\r\n");
}

int X = GetNumber("Введите X: ");
int Y = GetNumber("Введите Y: ");
int Z = GetNumber("Введите Z: ");
int[,,] matrix = InitArray(X, Y, Z);
PrintMatrix(matrix);

