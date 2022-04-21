static void ParseContents(string s)
{
    foreach (char ch in s)
    {
        Console.WriteLine(ch);
    }

    Console.WriteLine();
    for (int i = 0; i < s.Length; i++)
    {
        Console.WriteLine(s[i]);
    }
}

static Boolean IsAtEvenIndex(string s, char ch)
{
    if (String.IsNullOrEmpty(s))
    {
        return false;
    }
    for (int i = 0; i < s.Length / 2 + 1; i = +2)
    {
        if (s[i] == ch)
        {
            return true;
        }
    }
    return false;
}

ParseContents("Hello World");

Console.WriteLine(IsAtEvenIndex("HeLLo", 'L'));

Console.WriteLine(IsAtEvenIndex("", 's'));