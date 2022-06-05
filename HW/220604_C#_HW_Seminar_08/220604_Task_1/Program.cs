// 1.Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void SortRowsDescending(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column - 1; j++)
        {
            for (int k = j + 1; k < column; k++)
                {
                    if (array[i, k] > array[i, j])
                    {
                        (array[i, k], array[i, j]) = (array[i, j], array[i, k]);
                    }
                }
        }
    }
}

int[,] Random2DArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон значений: ");
Console.Write("от ");
int from = int.Parse(Console.ReadLine());
Console.Write("до ");
int to = int.Parse(Console.ReadLine());
int[,] array = Random2DArray(row, column, from, to);
Print2DArray(array);
Console.WriteLine();
SortRowsDescending(array);
Print2DArray(array);