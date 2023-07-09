
//Задача №10
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