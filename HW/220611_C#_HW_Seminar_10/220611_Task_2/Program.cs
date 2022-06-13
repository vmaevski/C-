// 2. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого элемента.

void UniqueRandom2DigitNumbers(int[] arr, int n) // через строку
{
    string strNum = string.Empty;
    for (int i = 10; i < 100; i++)
    {
        strNum += i.ToString();
    }
    for (int i = 0; i < n; i++)
    {
        int randomI = new Random().Next(0, strNum.Length);
        if (randomI % 2 != 0) randomI -= 1;
        arr[i] = int.Parse(strNum[randomI].ToString())*10 + int.Parse(strNum[randomI + 1].ToString());
        string strTemp = string.Empty;
        for (int j = 0; j < strNum.Length; j++)
        {
            if (j != randomI && j != randomI + 1) strTemp += strNum[j];
        }
        strNum = strTemp;
    }
}

void Fill3DArrayWithUniqueRandom2DigitNumbers(int[,,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    if (x * y * z > 90)
    {
        Console.WriteLine("Количество неповторяющихся двузначных чисел не может быть больше 90!");
        Console.WriteLine("Задайте другую размерность массива.");
        Console.ReadLine();
        return;
    }
    int[] arrNum = new int[x * y * z];
    UniqueRandom2DigitNumbers(arrNum, x * y * z);
    int iArrNum = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = arrNum[iArrNum];
                iArrNum++;
            }
        }
    }
}

void Print3DArrayWithIndex(int[,,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int sheet = array.GetLength(2);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < sheet; k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})" + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Задайте размерность массива (M x N x K):");
Console.Write("M = ");
int m = int.Parse(Console.ReadLine());
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());
Console.Write("K = ");
int k = int.Parse(Console.ReadLine());
int[,,] array = new int[m, n, k];
Fill3DArrayWithUniqueRandom2DigitNumbers(array);
Print3DArrayWithIndex(array);