// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int f(int n)
{
    int res = 0;
    while (n > 0)
    {
        res += n % 10;
        n = n / 10;
    }
    return res;
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма всех чисел ровна = {f(n)}");