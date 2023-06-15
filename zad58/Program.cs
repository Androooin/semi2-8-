/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}




int[,] Create2dArray(int rows1, int colums1)
{
    

    int[,] cr2dArray = new int[rows1, colums1];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < colums1; j++)
        {
            cr2dArray[i, j] = new Random().Next(1, 4);
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

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}





int rows = ReadInt("Write count of rows ");
int columns = ReadInt("Write count of columns ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

array = Create2dArray(rows, columns);
Print2dArray(array);

Console.WriteLine();

secondArray = Create2dArray(rows, columns);
Print2dArray(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Error ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

Print2dArray(resultArray);
Lutsenko();