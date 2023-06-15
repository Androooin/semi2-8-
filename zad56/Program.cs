/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
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

void MinRows2dArray (int [,] array2d)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array2d.GetLength(1); i++)
    {
        minRow += array2d[0, i];
    }
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++) sumRow += array2d[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"{minSumRow + 1} rows");
}
    

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}




int[,] new2dArray = Create2dArray();
Print2dArray(new2dArray);
MinRows2dArray(new2dArray);
Lutsenko();