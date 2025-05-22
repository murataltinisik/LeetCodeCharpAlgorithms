int TotalDigitsNumber(int number)
{
    // Variables
    int result = 0;

    foreach (char num in number.ToString())
    {
        // Int Parse
        int digit = Int32.Parse(num.ToString());

        //
        result += digit;
    }
    
    return result;
}

Console.WriteLine("------------");
Console.WriteLine(TotalDigitsNumber(1234));
Console.WriteLine("------------");
Console.WriteLine(TotalDigitsNumber(999));
