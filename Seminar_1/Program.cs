// Однострочный комментарий
/* Многострочный комментарий
 */
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;

Console.WriteLine($" Квадрат числа {number} = {sqr}");

int sqr1 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($" Квадрат числа {number} = {sqr1}");

