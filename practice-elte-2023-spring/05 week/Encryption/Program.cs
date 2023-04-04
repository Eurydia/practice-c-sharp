using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<char, string> shift = new Dictionary<char, string>{
            { 'i', "aa"},
            { 'n', "ba"},
            { 'd', "ca"},
            { 'o', "ab"},
            { 'r', "bb"},
            { 'u', "cb"},
            { 'q', "ac"},
            { 'a', "bc"},
            { 'p', "cc"},
            { 'h', "ad"},
            { 'g', "bd"},
            { 'x', "cd"},
            { 'b', "ae"},
            { 's', "be"},
            { 'c', "ce"},
            { 'f', "af"},
            { 'k', "bf"},
            { 'j', "cf"},
            { 'y', "ag"},
            { 't', "bg"},
            { 'v', "cg"},
            { 'l', "ah"},
            { 'e', "bh"},
            { 'm', "ch"},
            { 'w', "ai"},
            { 'z', "bi"},
            { ' ', "ci"},

        };
        string buffer, word, encrypted = "";

        buffer = Console.ReadLine();
        word = buffer;

        for (int i = 0; i < word.Length; i++)
        {
            encrypted = $"{encrypted}{shift[word[i]]}";
        }

        Console.Write($"{encrypted}\n");
    }
}