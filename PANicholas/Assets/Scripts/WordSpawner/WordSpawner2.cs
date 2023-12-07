using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner2 : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay2 SpawnWord()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), 7f);

        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay2 wordDisplay = wordObj.GetComponent<WordDisplay2>();

        return wordDisplay;
    }
}
