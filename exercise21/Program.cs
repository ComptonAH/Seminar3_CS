Console.Write("Enter first X value: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first Y value: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second X value: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second Y value: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double vectorLength = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2));
vectorLength = Math.Round(vectorLength,3);

Console.Write(vectorLength);