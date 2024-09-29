using System;

class Reference
{
    private string _reference;

    public Reference()
    {
        _reference = "James 1:5";
    }
    public Reference(string NewReference)
    {
        _reference = NewReference;
    }
    public string ShowReference()
    {
        return _reference;
    }
}