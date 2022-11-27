
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да


int[] massiv = new int[] {6, 7, 19, 345, 3};

Console.WriteLine("Введи число для проверки в массиве:");
int n = int.Parse(Console.ReadLine()!);

if (FindNumber(massiv, n) == true)
    Console.WriteLine($"Число {n} присутствует в массиве!");
else
    Console.WriteLine($"Число {n} не присутствует в массиве!");


bool FindNumber(int[] mus, int num){
    foreach (int i in mus){
        if (i == num){
            return true;
        }
    }
    return false;
}
//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
/* int[] array = GetArray(10, -9, 9);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

bool rez=false;
for(int i=0; i< array.Length; i++){
    if (array[i] == number) rez=true;
}
if (rez==true) Console.WriteLine ("Да");
else Console.WriteLine ("Нет");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
 */