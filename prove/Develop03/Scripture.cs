using System;

class Scripture
{

    private string _stripture; //= "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
    public Scripture()
    {
        _stripture = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.\nBut let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";
    }
    public Scripture(string NewScripture, string NewReference)
    {
        _stripture = NewScripture;
        new Reference(NewReference);

    }

    public string DisplayScripture()
    {
        return _stripture;
    }








}