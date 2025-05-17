bool IsPalindrome(int x)
{
    // Int To String
    char[] xValues = x.ToString().ToCharArray();
    
    // New Number
    string newNumber = string.Empty;
    
    // Create Reverse Number
    for (int i = xValues.Length - 1; i >= 0; i--)
        newNumber += xValues[i].ToString();
    
    if(newNumber == x.ToString()) return true;
    return false;
}

Console.WriteLine($"{IsPalindrome(11)}");