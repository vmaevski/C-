// 2. Задайте числа M и N. Напишите программу, которая найдёт
// сумму натуральных элементов от M до N с помощью рекурсии.

 int SumNaturalNumbers(int m, int n)
{
    if (n < m) return 0;
    return n + SumNaturalNumbers(m, n - 1);
}
 
Console.WriteLine($"Сумма = {SumNaturalNumbers(1, 15)}");
Console.WriteLine($"Сумма = {SumNaturalNumbers(4, 8)}");
