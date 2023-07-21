
//Task 25
//Напишите программу, которая принимает на вход два числа (А и В) и возводит число А 
//в натуральную степень В (цикл)
/*

int Degree(int a, int b)
{
int count = 1;
int deg = 1;
while(count<=b)
{
    deg = deg * a;
    count++;
}
return deg;
}
Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, указывающее на желаемую степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(num1, num2));
*/

//Task27
//Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
/*
int Sum(int number)
{
    int ost = 0;
    while (number > 0)
    {
    ost = ost + (number%10);
    number = number / 10;
    }
    
    return(ost);
}
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр введенного числа = " + Sum(num1));

*/

//Task29
//Напишите программу, которая задает массив из m элементов и выводит их на экран.
//Разработать метод CreateArray(int size), генерирующий массив на основе данных, 
//вводимых пользователем

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++)
    {
        Console.WriteLine("Введите следующий элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
Console.Write("input length");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input min value");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max value");
int max = Convert.ToInt32(Console.ReadLine());
int[] myarray = CreateArray(length, min, max);
ShowArray(myarray);