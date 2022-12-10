// Задача 38: Задайте массив случайных вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.


double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble();
    return array;
}

void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void DiffMaxMin (double[] array)
{
    double max = array[0];
    double min = array[0];
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
     double dif = max-min;
    System.Console.WriteLine($"Разница между {max} и {min} равна {dif}");
}


Console.WriteLine("Введите размерность массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
PrintArray(array);
DiffMaxMin(array);
