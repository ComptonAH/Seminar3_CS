Console.Write("Enter a quarter of XY-plot: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if(quarter>0 && quarter<5)
{
    if (quarter == 1)
    {
        Console.WriteLine("Values of the selected quarter lie in range (X>0;Y>0)");
    }
    if (quarter == 2)
    {
        Console.WriteLine("Values of the selected quarter lie in range (X<0;Y>0)");
    }
    if (quarter == 3)
    {
        Console.WriteLine("Values of the selected quarter lie in range (X<0;Y<0)");
    }
    if (quarter == 4)
    {
        Console.WriteLine("Values of the selected quarter lie in range (X>0;Y<0)");
    }
}
else
{
    Console.WriteLine("Enter a quarter from 1 to 4");
}