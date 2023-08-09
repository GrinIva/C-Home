//Task 64
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от N до 1. Выполнить с помощью рекурсии

/*
void ShowNum(int n)
{
Console.Write(n + " "); 
if(n>1) ShowNum(n-1);
}

Console.WriteLine("input N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNum(n);
*/

//Task 66
//Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке 
// от M до N

/*
int ShowSum(int n, int m)
{
   
    if(n<=m)
    return (ShowSum(n+1,m)+n);
    else return 0;
}

Console.WriteLine("input n: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input m: ");
int m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowSum(n,m));
*/

//Task 68
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
//неотрицательных числа m и n. m=2 n=3. m=3 n=2

int Akkerman(int m, int n)
{
    if(m==0)
    return (n+1);
        else if(m>0 && n==0)
        return Akkerman(m-1,1);
    else
    return Akkerman(m-1,Akkerman(m,n-1));
        

}
Console.WriteLine("input m: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input n: ");
int n=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(m,n));