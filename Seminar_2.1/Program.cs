/*Напишите программу, которая на вход принимает трёхзначно
е число и удаляя вторую цифру, выводит двухзначное число*/

//Математический метод
int number = new Random().Next(100, 1000);
 Console.WriteLine(number);
Console.WriteLine($"Число без второй цифры имеет вид: {number/100}{number%10}");
Console.WriteLine();
int result = (number/100)*10+number%10;
Console.WriteLine(result);

//строковый метод
string num = num1.ToString();
if(num.Length !=3){
    Console.WriteLine("Неверное число!");
}
else
{
    Console.WriteLine(num[0], num[2]);
}