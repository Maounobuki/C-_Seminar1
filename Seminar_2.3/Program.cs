//Проверка кратности 2х чисел
Console.WriteLine("Введите число 1: ");
int a = int.Parse (Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

int c = a%b;
if(c !=0){
    Console.WriteLine(c);
}
else{
    Console.WriteLine("кратно");
}