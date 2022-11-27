// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// -4, -8, 8, 2] -> [4, 8, -8, -2]
/* int[] array = GetArray(4, -9, 9);
Console.WriteLine($"[ {String.Join(", ", array)} ]");

for(int i=0; i< array.Length; i++){
    array[i] *=-1;
}

Console.WriteLine($"[ {String.Join(", ", array)} ]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
} */
// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] mas = new int[] {-4, -8, 8, 2};


Console.WriteLine($"[{String.Join(",", GetArray(mas))}]");


// // --------------- Method -----------------

int[] GetArray(int[] array){
    // int[] arr = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        array[i] = -array[i];
    }
    return array;
}