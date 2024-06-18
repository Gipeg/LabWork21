int GetDaysCount(int month, int year)
{
    if (month < 1 || month > 12 || year < 0)
        throw new ArgumentOutOfRangeException("НЕПРАВИЛЬНО!!!");

    int[] daysInMoths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    bool isLeapYear = year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
    if (month == 2 && isLeapYear)
        return daysInMoths[month - 1] + 1;
    return daysInMoths[month - 1];
}
Console.WriteLine(GetDaysCount(2, 2000));
