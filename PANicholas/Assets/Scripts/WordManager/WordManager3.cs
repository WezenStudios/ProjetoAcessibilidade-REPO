using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordManager3 : MonoBehaviour
{
    public List<Word3> words;

    public WordSpawner3 wordSpawner;

    private bool hasActiveWord;
    private Word3 activeWord;

    public void AddWord()
    {
        Word3 word = new Word3(WordGenerator3.GetRandomWord(), wordSpawner.SpawnWord());
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
            foreach (Word3 word in words)
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
