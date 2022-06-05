// 3. (Решение в группах)
// Составить частотный словарь двумерного массива. 
// Частотный массив содержит информацию о том, сколько раз встречается элемент входных данных.
// значения элементов массива 0...9.

int[] FrequencyDictionary(int[,] arr, int from, int to)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] arrValue = new int[to - from];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arrValue[arr[i, j]]++;
        }
    }
    return arrValue;
}

void PrintFrequencyDictionary(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (arr[i] != 0)
        {
            Console.WriteLine($"{i} встречается {arr[i]} раз.");
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
PrintFrequencyDictionary(FrequencyDictionary(array, from, to));
