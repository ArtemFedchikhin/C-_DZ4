// Задача 29: Напишите программу, которая будет создавать массив из 8 символов и заполнять значениями от пользователя

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]




Console.Write($"Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите минимальный размер массива массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите максимальный размер массива массива: ");
int max = Convert.ToInt32(Console.ReadLine());

void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}


Console.Clear();
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

/*
int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[");
    for (int i = 0; i < array.Length - 1; i++);
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int length = Prompt("Длина ");
int min = Prompt("начальное ");
int max = Prompt("конечное ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
*/


