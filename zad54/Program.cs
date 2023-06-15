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


int[,] Create2dArray()
{
    Console.WriteLine("Write count of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write count of colums");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] cr2dArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            cr2dArray[i, j] = new Random().Next(1, 10);
        }
    }
    return cr2dArray;
}

void Print2dArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array2d.GetLength(1) - 1; j++)
        {
            Console.Write(array2d[i, j] + ", ");
        }
        Console.WriteLine($"{array2d[i, array2d.GetLength(1) - 1]}]");

    }
    Console.WriteLine();
}

void SortArray2d(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            for (int k = 0; k < array2d.GetLength(1) - 1; k++)
            {
                if (array2d[i, k] < array2d[i, k + 1])
                {
                    int temp = array2d[i, k + 1];
                    array2d[i, k + 1] = array2d[i, k];
                    array2d[i, k] = temp;
                }
            }
        }
    }
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}




int[,] new2dArray = Create2dArray();
Print2dArray(new2dArray);
SortArray2d(new2dArray);
Print2dArray(new2dArray);
Lutsenko();