void PrintArray(double[,] matr) // Метод вывода массива на экран
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr) //метод заполнения массива рандомными значениями
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().NextDouble(); // "[оператор Next воспринимает интервал в таком виде)"
        }
    }
}
double[,] matrix = new double[3, 4]; // Игнициализация двумерного массива
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);