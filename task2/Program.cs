namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r1 = 10;
            double r2 = 5;
            double S = Math.PI * (r1 - r2) * (r1 * r2);
            Console.WriteLine(S);

            int n = 100;
            int sum = n * (n + 1) / 2;
            Console.WriteLine(sum);
        }
    }
}
