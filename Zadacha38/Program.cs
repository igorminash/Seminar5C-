int [] array = GetArray(21, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");



int GetSum (int [] array1){
    int diff = 0;
    int maxNum = array[0];
    int minNum = array[0];
    for (int i = 0; i < array1.Length; i++){
        if (array[i] > maxNum ) maxNum = array[i];
        if (array[i] < minNum ) minNum = array[i];
        diff = maxNum - minNum;
    }
    return diff;
}


Console.WriteLine($" Разница между максимальным и минимальным значением массива = {GetSum(array)}");

int [] GetArray(int size, int minValue, int maxValue){
    int [] massive = new int [size];
    for (int i = 0; i < size; i++){
        massive[i] = new Random().Next(minValue, maxValue);
    }
    return massive;
}