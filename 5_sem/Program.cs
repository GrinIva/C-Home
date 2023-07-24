//Task 34. Задайте массив заполненный случайными трехзначными положительными числами.
//напишите программу, которая покажет количество четных чисел в массиве

/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int []array)
{
    for (int i = 0; i<array.Length; i++) 
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int CountEvenNumber(int []array)
{
    int count = 0;
    for(int i=0;i<array.Length;i++)
    {
       if(array[i]%2==0)
            count++;
    }
    return count;
}

Console.WriteLine("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;
int[] myarray = CreateArray(length,min,max);
ShowArray(myarray);

Console.WriteLine("Массив содержит " + CountEvenNumber(myarray) + " четных элемента");
*/

//Task 36.
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечетных позициях (i=1(3,5,7...))

int[] NewArrayCreate(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i]=new Random().Next(minValue,maxValue+1);
    return array;
}

void ShowArray(int[]array)
{
    for(int i=0;i<array.Length; i++)
        Console.Write(array[i] + " ");
}Console.WriteLine();

int OddIndexSum(int[]array)
{
    int oddSum = 0;
    for(int i=1;i<array.Length;i=i+2)
        oddSum=oddSum+array[i];
    return oddSum;
}

Console.WriteLine("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте max: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myarray = NewArrayCreate(length,min,max);
ShowArray(myarray);
Console.WriteLine("Sum of numbers with odd index is " + OddIndexSum(myarray));

//Task38.
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//зачениями элементов массива