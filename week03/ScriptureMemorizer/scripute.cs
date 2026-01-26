using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }
    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.Ishidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new Random();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);


        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.Ishidden() == false)
            {
                return false;
            }
        }
        return true;
    }
    public string GetDisplayText()
    {

        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + "\n" + text;
    }
}

