double GetPower(double x, int n)
{
    if (n == 0)
        return 1;
    if (n < 0)
    {
        double temp = GetPower(x, n / 2);
        return n % 2 == 0 ? temp * temp : temp * temp * x;
    }
    return -1;
}
Console.WriteLine(GetPower(2, 15));
