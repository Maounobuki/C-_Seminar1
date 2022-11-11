Console.Write("Введите число");
int N = int.Parse(Console.ReadLine()!);

int N2 = -N;
while (N2 <= N)
{
    Console.Write($"{N2}, ");
    N2++;
}