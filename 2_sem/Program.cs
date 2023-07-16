
//Задача №10

/*
// Напишите программу, которая принимает на вход трехзначное число и на входе показывает ВТОРУЮ цифру этого числа


//met
int CutNum(int num)
{
    int hundred = num % 100;
    int result = hundred / 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());


if (num1 > 100 & num1 < 1000)

{
    int second_num = CutNum(num1);
    Console.Write(second_num);
}

else
{
    Console.Write("Неверно. Нужно ввести трехзначное число. Перезапустите программу и попробуйте снова.");
}


*/


//Задача№13

/*
//Напишите программу, которая выводит третью цифру заданного чтисла
int CutNumber(int num, int num2)
{
    int hundred = num / Convert.ToInt32(Math.Pow(10, (num2-3))); //Приведение к 3-х значному числу
    int result = hundred % 10;
    return result;
}
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 1;
int test = num1 / 100; // Проверка введенного числа на наличие третьего разряда
int test2 = num1 / 10; // Переменная для нахождения разрядности введенного числа и приведения его к 3-х значному

if (test > 0)
{
    while (test2 > 0)
    {
        test2 = test2 / 10;
        //Console.WriteLine("Остаток2 " + test2);
        count = count + 1;
        //Console.WriteLine("счетчик " + count);
    }
    int third_num = CutNumber(num1, count);
    Console.Write("Третья цифра введенного числа: " + third_num);
}
else
{
    Console.Write("Ошибка: ваше число меньше трехзначного");
}

*/

bool RestDay(int num)
{
    if(num > 5 && num <= 7) return true;
    else return false;
}


Console.WriteLine("Введите число: ");
int daynumber = Convert.ToInt32(Console.ReadLine());
bool result = RestDay(daynumber);
Console.WriteLine(result);
if (result == true) Console.Write("Выходной");
else Console.Write("Работай");


      


