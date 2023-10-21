Console.Write("Введите m и n:");
int[] dataUser = Console.ReadLine()
                        .Split()
                        .Where(s => int.TryParse(s, out _))
                        .Select(s => int.Parse(s))
                        .ToArray();

if (dataUser.Length == 2)
{
    Console.WriteLine(Akkerman(dataUser[0], dataUser[1]));
}

int Akkerman(int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}

