/*Напишите программу, которая принимает на 
вход число и выдаёт количество цифр в числе.*/


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество знаков числа: {Div(a)}");

int Div(int check)
{
int count = 0;
 while(check > 0)
 {
check = check/10;
count++;
 }
 return count;
}

