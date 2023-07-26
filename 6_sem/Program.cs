//task41
void CountPositiveNumbers()
{
Console.WriteLine("Input number of numbers");
int n = Convert.ToInt32(Console.ReadLine());
int count=0;
    for(int i=1;i<n;i++)
        {
            console.WriteLine("Input a number: ");
            int number=Console.ReadLine();
            if(number>0) 
            count++;
        }
    Console.WriteLine("Number of positive numbers is: "+ count);

}
CountPositiveNumbers();
//task43