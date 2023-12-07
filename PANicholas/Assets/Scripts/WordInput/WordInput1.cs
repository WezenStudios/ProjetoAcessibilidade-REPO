using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput1 : MonoBehaviour
{
    public WordManager1 wordManager;

    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
    }
}
