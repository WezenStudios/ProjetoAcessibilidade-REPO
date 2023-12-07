using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput4 : MonoBehaviour
{
    public WordManager4 wordManager;

    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
    }
}
