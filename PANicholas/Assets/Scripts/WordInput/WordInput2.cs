using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput2 : MonoBehaviour
{
    public WordManager2 wordManager;

    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
    }
}
