bool WordChain(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        if (i != words.Length - 1)
        {
            // Get Current Word
            string currentWord = words[i];
            
            // Get Next Word
            string nextWord = words[i + 1];
            
            // Get First Character
            string newLetter = nextWord.Substring(0, 1).ToLower();   
            string currentLetter = currentWord.Substring(currentWord.Length - 1);   
            
            // Compare
            if (newLetter != currentLetter) return false;
        }
    }
    
    return true;
}

string[] array = new string[] { "dog", "goose", "elephant", "tiger" };
string[] array2 = new string[] { "apple", "egg", "giraffe", "elephant", "tiger" };

Console.WriteLine("--------------");
Console.WriteLine(WordChain(array));
Console.WriteLine("--------------");
Console.WriteLine(WordChain(array2));
Console.WriteLine("--------------");