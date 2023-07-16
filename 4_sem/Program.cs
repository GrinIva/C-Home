
//Task 25
//Напишите программу, которая принимает на вход два числа (А и В) и возводит число А 
//в натуральную степень В (цикл)

int Degree(int a, int b)
{
int count = 1;
int deg = 1;
while(count<=b)
{
    deg = deg * a;
    count++;
}
return deg;
}
Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, указывающее на желаемую степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(num1, num2));

//Task27
//
//Task29
//

