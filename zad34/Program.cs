// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 


int[] CreateArray(int size)  
{ 
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
        array[i] = new Random().Next(100, 1000); 
    return array; 
} 
 
void PrintArray(int[] array) 
{ 
    foreach (int el in array)   
        Console.Write($"{el} "); 
        Console.WriteLine(); 
}

void CountNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    if (array[i]%2==0)
    count+=1;
    Console.WriteLine($"{count}");
}

int[] array = CreateArray(10); 
PrintArray(array); 
CountNumbers(array);
