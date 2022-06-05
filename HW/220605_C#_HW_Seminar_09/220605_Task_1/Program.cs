// 1. Задайте числа M и N. Напишите программу, которая выведет
// все чётные натуральные числа от M до N с помощью рекурсии.

 void EvenNaturalNumbers(int m, int n)
{
    n = n/2 * 2;
    if (n < m) return;
    EvenNaturalNumbers(m, n - 2);
    Console.Write($"{n}, ");
}
 
EvenNaturalNumbers(1, 11);