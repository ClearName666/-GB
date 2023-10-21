// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int[] dataUser = Console.ReadLine()
                        .Split()
                        .Where(s => int.TryParse(s, out _))
                        .Select(s => int.Parse(s))
                        .ToArray();


int End = dataUser.Last();
int Start = dataUser.First();

int Val = End+Start;
int LenHalf = (End-Start) / 2;

if (Start < End)
{
    if (End-Start % 2 == 0) Console.WriteLine(Val*LenHalf);
    else Console.WriteLine(Val*LenHalf+(Val/2));   
}




