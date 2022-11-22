Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма: {GetSum(a)}");


int GetSum(int limit){
    int sum = 0;
    for (int i = 1; i <=limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}