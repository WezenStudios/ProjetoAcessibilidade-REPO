using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordManager4 : MonoBehaviour
{
    public List<Word4> words;

    public WordSpawner4 wordSpawner;

    private bool hasActiveWord;
    private Word4 activeWord;

    public void AddWord()
    {
        Word4 word = new Word4(WordGenerator4.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word4 word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
