string alphabet = "abcdefghijklmnopqrstuvwxyz";

bool PangramControl(string input)
{
    // Variables
    int counter = 0;
    string value = input.ToLower();
    
    // For
    for (int i = 0; i < alphabet.Length; i++)
    {
        // Is Found
        bool isFound = false;

        // For
        for (int j = 0; j < value.Length; j++)
            if (alphabet[i] == value[j])
            {
                // Is Found
                isFound = true;
                
                // Break;
                break;
            }
        
        if (isFound) counter++;
    }
    
    return counter == alphabet.Length;
}

Console.WriteLine("-------------");
Console.WriteLine(PangramControl("The quick brown fox jumps over the lazy dog"));
Console.WriteLine("-------------");
Console.WriteLine(PangramControl("Hello world"));