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

static string Reverse2(string s)
{
    if (String.IsNullOrEmpty(s))
    {
        return s;
    }
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}

Console.WriteLine(Reverse("Hello World"));
Console.WriteLine(Reverse2("Hello World"));