// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// ==================================================================
Console.Clear();
// ==================================================================
void Main()
{
    int M = ReadInt("Введите Первое неотрицательное число: ");
    int N = ReadInt("Введите Второе неотрицательное число: ");
    System.Console.WriteLine();
    TaskMethod(M, N);
    Console.WriteLine($"Функция Аккермана = {TaskMethod(M, N)}");
    System.Console.WriteLine();
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int TaskMethod(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
        return TaskMethod(M - 1, 1);
    }
    else if (M > 0 && N > 0)
    {
        return TaskMethod(M - 1, TaskMethod(M, N - 1));
    }
    else return 0;
}

Main();
