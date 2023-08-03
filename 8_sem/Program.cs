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

/*

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
*/

//Task 58
//
/*
int[,]Create2DArray(int row, int col)
{
    int[,]array = new int[row,col];
    for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            array[i,j]=new Random().Next(1,5);
        }
    return array;
}

bool Check(int [,]array1, int [,]array2)
{
    if(array1.GetLength(1)==array2.GetLength(0))
        return true;
    else
        return false;
}


int [,]MatrixProduct(int [,] array1, int [,] array2)
{  
    int[,]matrix = new int[array1.GetLength(0), array2.GetLength(1)];
        
        for(int i=0;i<array1.GetLength(0);i++)
        {
            for(int j=0;j<array2.GetLength(1);j++)
            {   
                int sum = 0;
                for(int k=0;k<array1.GetLength(1);k++)
                {
                    sum = sum + array1[i,k]*array2[k,j];
                    matrix[i,j] = sum;
                }
            }
            
        }
    return matrix;
    
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

Console.WriteLine("input row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input col: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input row1: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input col1: ");
int col1 = Convert.ToInt32(Console.ReadLine());


int[,]myarray1 = Create2DArray(row,col);
int[,]myarray2 = Create2DArray(row1,col1);

Show2dArray(myarray1);

Show2dArray(myarray2);

if(Check(myarray1,myarray2)==true) 
    {
        int[,]myarray3 = MatrixProduct(myarray1, myarray2);
        Show2dArray(myarray3);
    }
else
{
Console.WriteLine("error");    
}
    
*/

//Task60
// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив добавляя индексы каждого элемента

int[,,] Create3dMassive(int row, int col, int shir, int minValue, int maxValue)
{
    int[,,] array = new int[row, col, shir];

    for (int i = 0; i < row; i++) 
        for (int j = 0; j < col; j++) 
            for(int z=0; z<shir; z++)
            array[i, j, z] = new Random().Next(minValue, maxValue+1);
    return array;
}

void Show3dArray(int [,,]array)
{   int sumj=-1;
    for(int i =0;i<array.GetLength(0);i++)
   
    {
        sumj++;
        int sumi=-1;
        for(int j=0;j<array.GetLength(1);j++)
        {
            sumi++;
            int sumz=-1;
            for(int z=0;z<array.GetLength(2);z++)
            {
                sumz++;
                Console.Write(array[i,j,z]+ "("+sumi+","+sumj+","+sumz+")");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("input row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input col: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input shir: ");
int shir = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("input minValue: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] my3darray = Create3dMassive(row,col,shir,min,max);
Show3dArray(my3darray);
