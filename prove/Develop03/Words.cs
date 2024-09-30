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
        int numbers = _numbers.Count - 1;
        if (numbers == -1)
        {
            return  _numbers.Count ;
        }
        else 
        {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(0, numbers );

        string _wordCount = _sentence[_numbers[magicnumber]];
        int _HideWordCount = _wordCount.Length;
        string _word = new string('_', _HideWordCount);
        _sentence[_numbers[magicnumber]] = _word;
        _numbers.RemoveAt(magicnumber);
        return _numbers.Count + 1;
        }
    }

    public void DisplaySentence()
    {
        Console.WriteLine(string.Join(" ", _sentence));
    }   
}