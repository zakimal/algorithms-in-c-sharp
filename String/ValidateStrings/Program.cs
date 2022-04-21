// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Linq;

static Boolean IsUpperCase(string s)
{
    return s.All(char.IsUpper);
}

static Boolean IsLowerCase(string s)
{
    return s.All(char.IsLower);
}

static Boolean IsPasswordComplex(string s)
{
    return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
}

Console.WriteLine(IsUpperCase("HELLO"));
Console.WriteLine(IsLowerCase("hello"));
Console.WriteLine(IsPasswordComplex("ThisIsC0mplex!"));