using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordManager1 : MonoBehaviour
{
    public List<Word1> words;

    public WordSpawner1 wordSpawner;

    private bool hasActiveWord;
    private Word1 activeWord;

    public void AddWord()
    {
        Word1 word = new Word1(WordGenerator1.GetRandomWord(), wordSpawner.SpawnWord());
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
            foreach (Word1 word in words)
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
