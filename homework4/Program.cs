using System.Text;
using System.Collections.Generic;

namespace homework4;

class Censor
{
    private List<string> _bannedWords = new List<string>();
    private string _textToCensor;

    public Censor(string textToCensore)
    {
        _textToCensor = textToCensore;
    }
    public void AddBannedWord(string word)
    {
        _bannedWords.Add(word);
    }

    public void RemoveBannedWord(string word)
    {
        if (_bannedWords.Contains(word))
        {
            _bannedWords.Remove(word);
        }
        else
        {
            Console.WriteLine("That word is not banned!");
        }
    }

    public void ShowAllBannedWords()
    {
        Console.WriteLine("Censored words:");
        foreach (string word in _bannedWords)
        {
            Console.WriteLine(word);
        }
    }
    public void CensoreText()
    {
        for (int i = 0; i < _bannedWords.Count; i++)
        {
            string censoredWord = new string('*', _bannedWords[i].Length);
            _textToCensor = _textToCensor.Replace(_bannedWords[i], censoredWord , StringComparison.OrdinalIgnoreCase);
        }
    }

    public override string ToString()
    {
        return _textToCensor;
    }
}

class Program
{
    
    static void Main(string[] args)
    {
        string text = "To be, or not to be, that is the question," +
                      "\nWhether 'tis nobler in the mind to suffer" +
                      "\nThe slings and arrows of outrageous fortune," +
                      "\nOr to take arms against a sea of troubles," +
                      "\nAnd by opposing end them? To die: to sleep;" +
                      "\nNo more; and by a sleep to say we end\nThe heart-ache and the thousand natural shocks" +
                      "\nThat flesh is heir to, 'tis a consummation\nDevoutly to be wish'd. To die, to sleep";
        Censor censor = new Censor(text);
        censor.AddBannedWord("die");
        censor.CensoreText();
        Console.WriteLine(censor);
    }
}