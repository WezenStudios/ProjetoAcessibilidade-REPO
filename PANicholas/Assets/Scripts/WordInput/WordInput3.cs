using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput3 : MonoBehaviour
{
    public WordManager3 wordManager;

    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
    }
}
