Dictionary<string, int> romanSymbols = new()
{
    { "I", 1 },
    { "V", 5 },
    { "X", 10 },
    { "L", 50 },
    { "C", 100 },
    { "D", 500 },
    { "M", 1000 }
};

int RomanToInt(string s)
{
    // Result
    int result = 0, currentValue = 0;
    
    for (int i = 0; i < s.Length; i++)
    {
        // Get Roman Value with i
        currentValue = romanSymbols[s[i].ToString()];

        // If this is not the last character and the next character has a higher value,
        // subtract current from result (e.g., IV = 5 - 1)
        if (i + 1 < s.Length && romanSymbols[s[i + 1].ToString()] > currentValue)
        {
            result -= currentValue;
        }
        else
        {
            // Otherwise, simply add the current value
            result += currentValue;
        }
    }
    
    return result;
}

Console.WriteLine(RomanToInt("III"));
Console.WriteLine("------------------");
Console.WriteLine(RomanToInt("LVIII"));
Console.WriteLine("------------------");
Console.WriteLine(RomanToInt("MCMXCIV"));
Console.WriteLine("------------------");
