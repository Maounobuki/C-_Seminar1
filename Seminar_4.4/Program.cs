/*Задача 28:
Найти произведение всех элементов массива целых чисел,
 меньших заданного числа. Размерность массива –10. Заполнение массива осуществить 
 случайными числами от 50 до 100.
*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
Console.WriteLine($"Количество знаков числа: {Multiply(array)}");

int Multiply(int [] array )
{
    int length = array.Length;
    int index = 0;
    int mult = 1;
    while(index < length)
    {
        array[index] = new Random().Next(50, 100);
        index++;
      mult *= array[index];
    }
      
   return mult;
}
/*Console.Write("Введите  размер массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = new int[n];*/


/*Console.Write($"Произведение массива = {Proiz(array, n)}");
//Console.WriteLine($"[{String.Join(",", array)}]");

int Proiz(int[] massiv,int size){
    int p = 1;
    for(int i=0 ; i<size ;i++){
        massiv[i] = new Random().Next(50,100);
        p *= massiv[i];
    }
    return p;
}*/

/// Задача 28: Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива – 10. Заполнение массива осуществить случайными числами от 50 до 100.

/* int[] arr= array(10);
Console.WriteLine($"Массив [{String.Join(", ",arr)}]");
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение элементов меньше {Num} следующее {arrayPr(arr, Num)}");

int[] array(int number){  // Заполнение массива
    int[] array1= new int[number];
     for(int i=0; i<array1.Length; i++){
        array1[i] = new Random().Next(50,101);
    }
    return array1;
}
int arrayPr(int[] array, int number){  // Произведение элементов
    int Proizv=1;
     for(int i=0; i<array.Length; i++){
        if (array[i]<number){
            Proizv=Proizv*array[i];
        }
       }
    return Proizv;
}*/
