
//47 task

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

