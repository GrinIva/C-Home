//Task 54
//задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int[,] Create2dMassive(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < row; i++) 
        for (int j = 0; j < col; j++) 
            array[i, j] = new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray(int [,]array)
{
    for(int i =0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
}

//Sort row 

void SortRowArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int k=j;k<array.GetLength(1);k++)
            {
                int temp = array[i,j];
                if(array[i,k]>array[i,j])
                {
                    array[i,j]=array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("input row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input col: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input minValue: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] my2darray = Create2dMassive(row,col,min,max);
ShowArray(my2darray);
Console.WriteLine();
SortRowArray(my2darray);
ShowArray(my2darray);
*/

//Task 56
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов


int[,] Create2dMassive(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < row; i++) 
        for (int j = 0; j < col; j++) 
            array[i, j] = new Random().Next(minValue, maxValue+1);
    return array;
}

void Show2dArray(int [,]array)
{

    for(int i =0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
}

int[] CreateArray(int[,]my2darray)
{
    int[] array = new int[my2darray.GetLength(0)];

    for(int k=0;k<my2darray.GetLength(0);k++)
    {
        int sum = 0;
        for(int i=k;i<k+1;i++)
        {   
                
            for(int j=0;j<my2darray.GetLength(1);j++)
            {
                    
                sum = sum +my2darray[i,j];
                array[k] =sum;
                        
            }        
        }
    }        
    return array;
}


void ShowArray(int[]array)
{
    for(int k=0;k<array.Length; k++)
        Console.Write(array[k] + " ");
    Console.WriteLine();
}

void FindMin(int[]array)
{
    int rowindex=0;
    int min = array[rowindex];
    for(int i=0;i<array.Length;i++)
        if(array[i]<min) 
        {
            min=array[i];
            rowindex=i;
        }
    Console.WriteLine($"Row № {rowindex} of my2darray have a min sum elements =  {min}");
    
}

Console.WriteLine("input row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input col: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input minValue: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] my2darray = Create2dMassive(row,col,min,max);
Show2dArray(my2darray);
int[] myarray = CreateArray(my2darray);
ShowArray(myarray);
FindMin(myarray);