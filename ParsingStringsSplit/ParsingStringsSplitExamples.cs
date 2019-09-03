using System;

public class ParseStringsUsingSplit
{
	public void splitStringExample()
    {
        string phrase = "The quick brown fox jumps over the lazy dog.";
        string[] words = phrase.Split(' ');

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }
        //This behavior makes it easier for formats like comma separated values (CSV) files representing tabular data. Consecutive commas represent a blank column.
    }

    public void splitStringExtraSpacesExample()
    {
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        string text = "one\ttwo three:four,five six seven";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(delimiterChars);
        System.Console.WriteLine($"{words.Length} words in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }
        //This behavior makes it easier for formats like comma separated values (CSV) files representing tabular data. Consecutive commas represent a blank column.
    }

    public void splitCharDelimiterExample1()
    {
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        string text = "one\ttwo three:four,five six seven";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(delimiterChars);
        System.Console.WriteLine($"{words.Length} words in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }
        //String.Split can use multiple separator characters. The following example uses spaces, commas, periods, colons, and tabs, all passed in an array containing these separating characters, to Split.The loop at the bottom of the code displays each of the words in the returned array.
    }

    public void splitCharDelimiterExample2()
    {
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        string text = "one\ttwo :,five six seven";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(delimiterChars);
        System.Console.WriteLine($"{words.Length} words in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }
        //String.Split can use multiple separator characters. The following example uses spaces, commas, periods, colons, and tabs, all passed in an array containing these separating characters, to Split.The loop at the bottom of the code displays each of the words in the returned array.
    }

    public void splitStringDelimiterExample()
    {
        string[] separatingStrings = { "<<", "..." };

        string text = "one<<two......three<four";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
        System.Console.WriteLine($"{words.Length} substrings in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine(word);
        }
        //String.Split can take an array of strings (character sequences that act as separators for parsing the target string, instead of single characters).
    }
}
