using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word1
{
    public string word;
    private int typeIndex;

    WordDisplay1 display;

    public Word1(string _word, WordDisplay1 _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            display.RemoveWord();
        }

        return wordTyped;
    }
}
