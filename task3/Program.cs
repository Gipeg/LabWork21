int bytes = 1 << 30;
Console.WriteLine(GetSize(bytes));

string GetSize(int bytes)
{
    return (bytes < (1 << 10)) ? $"{bytes}Б" :
           (bytes < (1 << 20)) ? $"{bytes >> 10}КБ" :
           (bytes < (1 << 30)) ? $"{bytes >> 30}МБ" : $"{bytes >> 30} ГБ";
}

