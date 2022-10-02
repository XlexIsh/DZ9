// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 5, 6, 7, 8""

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

void GetNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    Console.WriteLine(m);
    GetNumbers(++m, n);
}

GetNumbers(m, n);