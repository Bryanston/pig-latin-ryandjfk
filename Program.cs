// Console template
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string userInput = Console.ReadLine();
        string pigLatin = "";
        string[] sentence = userInput.Split(' ');
        foreach (string word in sentence)
        {
            pigLatin += PigLatin(word) + " ";
        }
        Console.WriteLine(pigLatin);
    }

    static string PigLatin(string word)
    {
        string result = "";
        char firstLetter = word[0];

        string substring = word.Substring(1);

        result = substring + firstLetter + "ay";

        return result;
    }
}
