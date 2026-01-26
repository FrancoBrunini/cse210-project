using System;
using System.Collections.Generic;


public class Reference
{
    private string _book;
    private int _endverse;
    private int _chapter;
    private int _startverse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = verse;
        _endverse = verse;
    }
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }
    public string GetDisplayText()
    {
        if (_endverse == _startverse)
        {
            return $"{_book} {_chapter}:{_startverse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startverse}-{_endverse}";
        }
    }
    
}