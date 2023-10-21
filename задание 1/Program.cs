//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int[] dataUser = Console.ReadLine()
                        .Split()
                        .Where(s => int.TryParse(s, out _))
                        .Select(s => int.Parse(s))
                        .ToArray();
int End = dataUser.Last();
int Start = dataUser.First();

AllNumbernItermission(Start, End);

void AllNumbernItermission(int start, int end)
{
    if (start > end) return;
    Console.Write($" {start}");
    AllNumbernItermission(start+1, end);
}
