using System.Text;

static string Reverse(string s)
{
    if (String.IsNullOrEmpty(s))
    {
        return s;
    }

    StringBuilder reversed = new StringBuilder(s.Length);
    for (int i = s.Length - 1; 0 <= i; i--)
    {
        reversed.Append(s[i]);
    }

    return reversed.ToString();
}

static string ReverseEachWord(string s)
{
    if (String.IsNullOrEmpty(s))
    {
        return s;
    }
    StringBuilder result = new StringBuilder(s.Length);
    string[] arr = s.Split(" ");
    for (int i = 0; i < arr.Length; i++)
    {
        result.Append(Reverse(arr[i]));
        if (i != arr.Length - 1)
        {
            result.Append(" ");
        }
    }
    return result.ToString();
}

Console.WriteLine(ReverseEachWord("Hello, world!"));