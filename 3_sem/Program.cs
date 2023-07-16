
//1.
/*
//Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли 
//оно палиндромом 

int Revers(int number)
{
    int numrevers = 0;
    int num3 = 0;

    while(number > 0)
    {
        num3 = number % 10;
        numrevers = numrevers * 10 + num3;
        number = number / 10;
    }
    return numrevers;
       
}

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Revers(num));
int numr = Revers(num);

if (num == numr) Console.WriteLine("Введенное вами число - полиндром");
else Console.WriteLine("Введенное вами число - не полиндром");
*/


//2.
/*
//Напишите прогшрамму , которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве 

double Distanse(int cx1, int cy1, int cz1, int cx2, int cy2, int cz2)
{
double dist = Math.Sqrt((Math.Pow((cx2-cx1),2) + Math.Pow((cy2-cy1),2) + Math.Pow((cz2-cz1),2))); 
return dist;
}

Console.WriteLine("Введите координаты x первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z первой точки ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты x второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());

double rezult = Distanse(x1, y1, z1, x2, y2, z2);
Console.WriteLine(rezult);
*/


//3
/*
//Напишите программу, которая принимает на вход число (N) и выдает таблицу  кубов 
// чисел от 1 до N

//method void
void TabKub (int number)
{
    int count =1;
    while (count <= number)
    {
        Console.WriteLine($"{count} * {count} * {count} = {count*count*count}");
        count++;        
    }
    
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
TabKub(number);
*/