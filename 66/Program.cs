// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число m: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

if (isNumberM != true)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine("Введите число n: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM != true)
{
    Console.WriteLine("Ошибка!");
    return;
}

int GetSum(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + GetSum(++m, n);
    }
}

int sum = GetSum(m, n);
Console.WriteLine(sum);