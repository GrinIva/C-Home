
//47 task
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
