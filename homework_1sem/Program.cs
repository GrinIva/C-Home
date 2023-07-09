

//1. Задача №2

/*

//Напишите программу , которая запрашивает на вход два числа и выдает большее число

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.Write("Из введенных вами чисел наибольшее: " + num1);
}
else
{
    Console.Write("Из введенных вами чисел наибольшее: " + num2);
}

*/

//2. Задача№4

/*

//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("Из введенных вами чисел наибольшее: " + max);
*/

//3. Задача№6
//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два безх остатка).


Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int EvNum = num1 % 2;
if(EvNum == 0)
{
Console.Write("Число четное");    
}
else
Console.Write("Число нечетное");

