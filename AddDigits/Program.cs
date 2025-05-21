int AddDigits(int num)
{
    if (num == 0) return 0;
    return 1 + (num - 1) % 9;
}

Console.WriteLine("------------");
Console.WriteLine(AddDigits(38));
Console.WriteLine("------------");
Console.WriteLine(AddDigits(0));
