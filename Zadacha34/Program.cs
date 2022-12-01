int [] arr = new int[4];
GetArray(arr);
Console.WriteLine($"В полученном массиве: [{String.Join(", ", arr)}], количество четных элементов - {GetQuantity(arr)}");

int [] GetArray (int [] array1){
    
for(int i = 0; i < array1.Length; i++){
    array1 [i] = new Random().Next(100,1000);
     
    }
    return array1;
}

int GetQuantity (int [] array1){
    int count = 0;
    foreach (int i in array1){
        if ( i % 2 == 0){
            count ++;
        }
    }
    return count;
}
