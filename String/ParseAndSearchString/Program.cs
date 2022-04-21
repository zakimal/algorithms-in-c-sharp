static void ParseContents(string s) {
    foreach(char ch in s) {
        Console.WriteLine(ch);
    }

    Console.WriteLine();
    for (int i = 0; i < s.Length; i++) {
        Console.WriteLine(s[i]);
    }
}

ParseContents("Hello World");