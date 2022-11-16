//Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());

if (numA * numA == numB || numB * numB == numA)
{
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет");
}
