Console.WriteLine("Введите размер массива");
int N = int.Parse(Console.ReadLine()!);
int [] array = new int[N];
PrintArray(array);
GetQuantity(array);

 

void PrintArray(int [] array){
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next (0,10);
    }
    Console.WriteLine($"В массиве: [{String.Join(", ", array)}]");
}

void GetQuantity(int [] array){
    int size;
    if (array.Length%2 == 0) size = array.Length/2;
    else size = (array.Length/2) +1;
    int [] array1 = new int [size];
    int A = 0;
    int B = 0;
    int C = array.Length-1;
     while(B < C)
    {
    array1[A] = array[B] * array[C];
    A++;
    B++;
    C--; 
   }
     if (array.Length%2 > 0){
    array1[A] = array[(array.Length/2)];
   }
 Console.WriteLine($" произведение пар чисел = [{String.Join(", ", array1)}] ");
}
