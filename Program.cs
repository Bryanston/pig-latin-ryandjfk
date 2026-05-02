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

        char lastLetter = word[word.Length - 1];
        if (char.IsPunctuation(lastLetter))
        {
            word = word.Substring(0, word.Length - 1);
        }
    
        string endPunctuation = punctuation(lastLetter.ToString());

        string substring = word.Substring(1);

        result = substring + firstLetter + "ay" + endPunctuation;

        return result;
    }

    static string punctuation(string s)
    {
       string punc = ".,!?";

        if (punc.Contains(s))
        {
            
            char puncChar = s[0];
            return puncChar.ToString();
        }
        else
        {
            return "";
        } 
    }
}
