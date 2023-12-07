using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordManager2 : MonoBehaviour
{
    public List<Word2> words;

    public WordSpawner2 wordSpawner;

    private bool hasActiveWord;
    private Word2 activeWord;

    public void AddWord()
    {
        Word2 word = new Word2(WordGenerator2.GetRandomWord(), wordSpawner.SpawnWord());
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
            foreach (Word2 word in words)
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
