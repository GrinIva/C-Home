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

int [,] Create2dArray(int row,int col,int minValue, int maxValue)
{
    int [,] array = new int[row,col];
    for(int i=0;i<row;i++)
        for(int j=0;j<col;j++);
        array[i,j]= newRandom().Next(minValue,maxValue);
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

void FindMinRow(int [,]array)
{
    int num = 0;
    int sum=0;
    for(int i=0;i<array.GetLength(0);i++);
    int rowsum=0;    
        for(int j=0;j<array.GetLength(1);j++)
        rowsum=sum+array(i,j);
        
}