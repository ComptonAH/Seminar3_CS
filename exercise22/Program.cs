Console.Write("Enter an integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int count = 1; count <= N; count++)
{
    int result = Convert.ToInt32(Math.Pow(count,2));
    Console.Write($"{result} ");
}