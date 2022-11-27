void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-200, 100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] numbers = new int[123];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 10 && numbers[i] <= 99) count += 1;
}
Console.WriteLine($"Количество чисел в отрезке [10,99] равно {count}");

/*// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = GetArray(123);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"В массиве найдено {Counter(array)} элементов в отрезке [10,99]");


int[] GetArray(int num, int r = 1000){
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(r);
    }
    return mas;
}

int Counter(int[] mas, int n = 9, int m = 100){
    int count = 0;
    foreach (int i in mas)
    {
        if (i < m && i > n)
        {
            count ++;
        }
    }
    return count;
}*/