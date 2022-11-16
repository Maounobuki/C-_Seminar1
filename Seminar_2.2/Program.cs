// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//78 -> 8

//12-> 2

//85 -> 8

int number = new Random().Next(10, 100);
string num = number.ToString();
Console.WriteLine(number);
if(num[0]>num[1]){
    Console.WriteLine(num[0]);
}
else{
    Console.WriteLine(num[1]);
}

