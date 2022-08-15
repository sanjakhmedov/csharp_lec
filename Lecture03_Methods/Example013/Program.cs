// Substitute "k" to "K", spaces to "-", "C" to "c".

string text = "It is a long established fact that a reader will be "
            + "distracted by the readable content of a page when "
            + "looking at its layout.";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, 'r', 'R');
Console.WriteLine(newText);