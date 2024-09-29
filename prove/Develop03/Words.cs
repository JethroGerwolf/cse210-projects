using System;
using System.Collections.Generic;
using System.Security.Cryptography;
class Words
{
    private List<string> _sentence ;

    private List<int> _numbers;

    public Words()
    {
        _sentence = [" "];
        _numbers = [];
    }

    public Words(string sentence)
    {
        
        _sentence = new List<string>(sentence.Split(' '));
        _numbers = new List<int>();
        
        int _NumberOfWords = _sentence.Count;
        for (int i = 0; i < _NumberOfWords; i++ )
        {
            _numbers.Add(i);
        }
    }

    public int hidewords()
    {
        int numbers = _sentence.Count;
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(0, numbers - 1);
        _numbers.RemoveAt(magicnumber);
        
        string _wordCount = _sentence[magicnumber];
        int _HideWordCount = _wordCount.Length;
        string _word = new string('_', _HideWordCount);
        _sentence[magicnumber] = _word;
        return numbers;
    }

    public void DisplaySentence()
    {
        Console.WriteLine(string.Join(" ", _sentence));
    }   
}