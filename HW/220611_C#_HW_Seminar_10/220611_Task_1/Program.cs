// 1. Есть монотонная последовательность, каждое число встречается ровно то кол-во раз,
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,...
// Выведите ряд этой последовательности до N-го значения, используя рекурсию: 
// N = 12 => "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5".
int j = 0;

void MonotonicSequence(int n)
{
    if (n < 1) return;
    MonotonicSequence(n - 1);
    if (j > 0)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{n}, ");
            j--;
            if (j < 1) return;
        }
    }
}

Console.Write($"Введите кол-во значений последовательности: ");
int n = int.Parse(Console.ReadLine());
j = n;
MonotonicSequence(n);