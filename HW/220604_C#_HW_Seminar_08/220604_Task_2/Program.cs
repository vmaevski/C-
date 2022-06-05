// 1.Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void StringWithMinimumSum(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int minSum = 0;
    int iStringWithMinimumSum = 0;
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
            sum += array[i, j];
        }
        Console.Write($"Sum = {sum}" + "\t");
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            iStringWithMinimumSum = i;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с минимальной суммой элементов: {iStringWithMinimumSum + 1}");
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
StringWithMinimumSum(array);
Console.WriteLine();