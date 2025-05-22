string RecurringCharacter(string str)
{
    string result = "none";
    
    for (int i = 0; i < str.Length; i++)
    {
       // Temp
       string temp = str.Substring(i, 1);

       // For Loop
       for (int j = i + 1; j < str.Length; j++)
       {
           if(temp == str[j].ToString())
               result = str[j].ToString();
       }
    }

    return result;
}

Console.WriteLine("------------");
Console.WriteLine(RecurringCharacter("abca"));
Console.WriteLine("------------");
Console.WriteLine(RecurringCharacter("abcdef"));
