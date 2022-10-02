// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число m: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

if (isNumberM != true || m < 0)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine("Введите число n: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberN != true || n < 0)
{
    Console.WriteLine("Ошибка!");
    return;
}

int CalculateTheAckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return CalculateTheAckermanFunction(m - 1, 1);
    }
    else
    {
        return CalculateTheAckermanFunction(m - 1, CalculateTheAckermanFunction(m, n - 1));
    }
}

int result = CalculateTheAckermanFunction(m, n);
Console.WriteLine(result);