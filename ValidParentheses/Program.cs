bool IsValid(string s)
{
    foreach (var c in s)
    {
        // Char Code
        int charCode = c;
        
        //
        if (charCode == 40)
        {
            
        }
    }
    
    return false;
}

/*
 * ( -> 40
 * ) -> 41
 *
 * { -> 123
 * } -> 125
 * 
 * [ -> 91
 * ] -> 93
 * 
 * 
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
   
   An input string is valid if:
   
   Open brackets must be closed by the same type of brackets.
   Open brackets must be closed in the correct order.
   Every close bracket has a corresponding open bracket of the same type.
 */

Console.WriteLine(IsValid("()"));
Console.WriteLine("-------------");
Console.WriteLine(IsValid("()[]{}"));
Console.WriteLine("-------------");
Console.WriteLine(IsValid("(]"));
Console.WriteLine("-------------");
Console.WriteLine(IsValid("([])"));
