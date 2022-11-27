int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[ {String.Join(", ", array)} ]");

int positivesum = 0;
int negativesum = 0;
foreach(int el in array){
   if(el>0)
   {
    positivesum+=el;
   }
   else 
   {
   negativesum+=el;
   }
}

Console.WriteLine($"[Сумма положительных: {positivesum} Сумма отрицательных: {negativesum}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}