//    Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс,   
//    минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и 
//    вывести на экран с пояснениями. Найти медианное значение первоначалального массива , 
//    возможно придется кое-что для этого дополнительно выполнить.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 50);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}


int Average(int[] array)
{
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i++;
    }
    int av = sum / array.Length;
    return av;
}

void Data(int[] array)
{
    int average = Average(array);
    int max = array[0];
    int min = array[0];


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];

        else if (array[i] < min) min = array[i];
    }
    int indexmax = Array.IndexOf(array, max);
    int indexmin = Array.IndexOf(array, min);
    int[] newArray = new int[5];
        newArray[0] = max;
        newArray[1] = indexmax;
        newArray[2] = min;
        newArray[3] = indexmin;
        newArray[4] = average;

    PrintArray(newArray);
    
    Console.WriteLine($"Максимальное число {max} под индексом {indexmax},Минимальное чило {min} под индексом {indexmin}. Среднее арифметическое {average}");
    
}

int[] Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min]) min = j;

        }

        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
    return array;
}

void Median(int[] array)
{
    int median = 0;
    if (array.Length % 2 == 0) median = (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2;
    else median = array[array.Length / 2];
    System.Console.WriteLine($"Медианное значение равно {median}");
}



int[] array = CreateArray(10);
PrintArray(array);
Data(array);
int[] newArray2 = Sort(array);
PrintArray(newArray2);
Median(newArray2);
