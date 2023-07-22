// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// ==================================================================
Console.Clear();
// ==================================================================
void Main()
{
    int M = ReadInt("Введите Первое число: ");
    int N = ReadInt("Введите Второе число: ");
    TaskMethod(M, N);
    Console.Write($"Сумма чисел от {M} до {N} = {TaskMethod(M - 1, N)}");
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int TaskMethod(int M, int N)
{
    int count = M;

    if (M == N) return 0;

    else
    {
        M++;
        count = M + TaskMethod(M, N);
        return count;
    }
}

Main();