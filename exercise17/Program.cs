Console.Write("Enter an X value:");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter an Y value:");
int Y = Convert.ToInt32(Console.ReadLine());

if(X!=0 && Y!=0)
{
    if (X>0 && Y>0)
    {
        Console.WriteLine("Your point lies in the first quarter");
    }
    if (X>0 && Y<0)
    {
        Console.WriteLine("Your point lies in the fourth quarter");
    }
    if (X<0 && Y<0)
    {
        Console.WriteLine("Your point lies in the third quarter");
    }
    if (X<0 && Y>0)
    {
        Console.WriteLine("Your point lies in the second quarter");
    }
}
else
{
    Console.WriteLine("Enter values are not equal to 0");
}