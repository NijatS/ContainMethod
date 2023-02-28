#region ReverseMethod
/*
string ReverseString(string sentence)
{
    string[] sentences = sentence.Split(' ');
    string newString = "";
    foreach (string s in sentences)
    {
        newString += Reversed(s) + " ";
    }
    return newString;
}

string Reversed(string sentence)
{
    string newsentence = "";
    
    for (int i = sentence.Length - 1; i >= 0; --i)
    {
        newsentence += sentence[i];
    }

    return newsentence;

}

string  sentence= "Hello World P136";
Console.WriteLine(ReverseString(sentence));
*/
#endregion


bool ContainsS(string sentence,string letters)
{
    sentence = sentence.ToLower();
    letters = letters.ToLower();
    int c = 0;
    int i = 0;
    foreach (var s in sentence) 
    {
        i = c;
        if (s == letters[i])
            {
                c++; 
                if (c == letters.Length)
                {
                    return true;
                }
            }
            else
            {
                c = 0;
        }
    }
    
    return false;
}
string sentence = "Hello World";
string letters = "Wor";

Console.WriteLine(ContainsS(sentence,letters));

