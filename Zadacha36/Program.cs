int [] massiv = new int[10];
GetArray(massiv);
Console.WriteLine($"В массиве [{String.Join(", ", massiv)}], сумма чисел под нечетным индексом = {GetSum(massiv)}");


int [] GetArray (int [] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(0,10);
    }
    return array;
}

int GetSum (int [] array){
    int Sum = 0;
    for (int j = 1; j < array.Length; j+=2){
        Sum = Sum + array[j];
    }
    return Sum;
}
