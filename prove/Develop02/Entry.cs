using System;
using System.ComponentModel.DataAnnotations;

class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    //public Entry( string date, string prompt, string entry)
    //{
    //    _date = date;
    //    _prompt = prompt;
    //    _entry = entry;
    //}
    public void Displaynewentry()
    {
        Console.WriteLine($"{_date} {_prompt}\n{_entry}");
    }
        public string formatentry()
    {
        return  $"{_date},{_prompt},{_entry}";
    }

}