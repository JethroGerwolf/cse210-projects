using System;
using System.Collections.Generic;
using System.IO;

class Journal{
    public List<Entry> _entry = new List<Entry>();
    public int Load_file = 0;


    public string _fileName; 
    
    
    public void Displayjournal()
    {
    
        foreach(Entry i in _entry)
        {
            i.Displaynewentry();
        }


    }

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
    {
    // You can add text to the file with the WriteLine method
    
    
        foreach(Entry i in _entry)
        {
        outputFile.WriteLine(i.formatentry());
        }
    }   
    }
        public void LoadFile()
    {

        _entry.Clear();
        string filename = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(_fileName);
        int count = 0;
    foreach (string line in lines)
    {
    
    string[] parts = line.Split(",");
    
        string date = parts[0];
        string prompt = parts[1];
        string entry = parts[2];

            
        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._prompt = prompt;
        newEntry._entry = entry;

        _entry.Add(newEntry);
    

    }
    }

}