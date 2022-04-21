static string NormalizeString(string s) {
    return s.ToLower().Trim().Replace(",", "");
}

Console.WriteLine(NormalizeString(" Hello There, BUDDY !  "));