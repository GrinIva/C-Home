
//47 task
//Задайте двумерный массив заполненный случайными вещественными числами
/*
void PrintArray(double[,] matr) // Метод вывода массива на экран
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)

            Console.Write($"{matr[i, j]} ");

        Console.WriteLine();
    }
}

void FillArray(double[,] matr) //метод заполнения массива рандомными значениями
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(new Random().Next(-100,100) + new Random().NextDouble(),2); // "[оператор Next воспринимает интервал в таком виде)"
        }
    }
}

double[,] matrix = new double[3, 4]; // Игнициализация двумерного массива
//double[,] matrix = new double[new Random().Next(1,3), new Random().Next(1,5)]; // Игнициализация двумерного массива
//PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/


//50 task
//Напишите программу, которая на входе принимает позиции элемента в двумерном массиве
//и возхвращает его значение. Или же возвращает указание, что такого элемента не существует
/*
void FillArray(int[,] matr) //метод заполнения массива рандомными значениями
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,50) ; // "[оператор Next воспринимает интервал в таком виде)"
        }
    }
    
}

void PrintArray(int[,] matr) // Метод вывода массива на экран
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)

            Console.Write($"{matr[i, j]} ");

        Console.WriteLine();
    }
}

bool ChekIndex(int[,] matr, int str, int col)
{
    if(str <= matr.GetLength(0) && col <=matr.GetLength(1))
        return true;
    else 
        return false;
}

int[,] matrix = new int[new Random().Next(1,10), new Random().Next(1,10)]; // Игнициализация двумерного массива
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("inp i");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("inp j");
int col = Convert.ToInt32(Console.ReadLine());

if (ChekIndex(matrix,str,col)==true)
    Console.WriteLine("Your number is " + matrix[str,col]);
else
    Console.WriteLine("No such element");
*/


//52 task
//задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//каждого столбца
/*
//int метод заполнения двумерного массива
int[,] Create2dArray(int row, int col, int minValue, int maxValue) 
{
    int[,] array = new int[row, col];

    for(int i=0;i<row;i++)
        for(int j=0;j<col;j++)
            array[i,j] = new Random().Next(minValue,maxValue);
    return array;
}
// Метод вывода массива на экран
void PrintArray(int[,] matr) 
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)

            Console.Write($"{matr[i, j]} ");

        Console.WriteLine();
    }
}

void MeanNumber(int[,] matr) // Метод вывода массива на экран
{
    
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        
   
        for (int i = 0; i < matr.GetLength(0); i++)
                    
            sum += matr[i,j];
            
        
        Console.WriteLine("Arithmetic mean of numbers in " + j +" colom is "+ sum/matr.GetLength(0));
    }
}


Console.WriteLine("Задайте количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,]myarray = Create2dArray(row,col,min,max);
PrintArray(myarray);
MeanNumber(myarray);
*/