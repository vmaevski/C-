// 3.Задайте две матрицы. напишите программу, которая будет находить
// произведение двух матриц.

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

int[,] Multiplication2Arrays(int[,] array1, int[,] array2)
{
//    if (array1.GetLength(1) != array2.GetLength(0))
    // {
    //     //return ;        ! ! ! Как ?????
    // }
    // else
//    {
        int row = array1.GetLength(0);
        int column = array2.GetLength(1);
        int col1row2 = array1.GetLength(1);
        int[,] arr = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = 0; k < col1row2; k++)
                {
                    arr[i,j] += array1[i,k] * array2[k, j];    
                }
            }   
        }
    return arr;
//    }
}

int[,] array1 = Random2DArray(2, 3, 1, 10);
int[,] array2 = Random2DArray(3, 3, 1, 10);
Print2DArray(array1);
Print2DArray(array2);
int[,] array3 = Multiplication2Arrays(array1, array2);
Print2DArray(array3);