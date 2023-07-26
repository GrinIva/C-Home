//task41
/*
void CountPositiveNumbers()
{
Console.WriteLine("Input number of numbers");
int n = Convert.ToInt32(Console.ReadLine());
int count=0;
    for(int i=1;i<=n;i++)
        {
            Console.WriteLine("Input a "+i+" number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            if(number>0) 
            count++;
        }
    Console.WriteLine("You have entered: "+ count + " positive numbers");

}
CountPositiveNumbers();

*/
//task43


void PointOfIntersection()
{
Console.WriteLine("Input ratio 'K' for the first equation: ");
double k=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ratio 'K' for the second equation: ");
double k2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ratio 'b' for the first equation: ");
double b=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ratio 'b' for the second equation: ");
double b2=Convert.ToDouble(Console.ReadLine());

    if(k==k2)
        if(b==b2)
        Console.WriteLine("The lines match");
        else
        Console.WriteLine("The lines are parallel");
    else
    {
    double x = (b2-b)/(k-k2);
    double y = k*x+b;
    Console.WriteLine($"Coordinates of intersection point: ({x}, {y})");
    }
}
PointOfIntersection();
