// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int f(int n1, int n2)
{
    int power = 1;
    for (int i = 0; i < n2; i++)
    {
        power *= n1;
    }
    return power;
}
Console.Clear();
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n2 < 0)
    Console.WriteLine("Степень не должена быть меньше нуля");
else
    Console.WriteLine($"{f(n1, n2)}");













// Console.Clear();
// Console.Write("Введите число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень числа: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Pow(n1,n2));