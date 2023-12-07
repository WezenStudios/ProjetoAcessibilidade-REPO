using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator2 : MonoBehaviour
{
    private static string[] wordList = 
        { 
        "atacador", "quebrar", "pirulito", 
        "derrotado", "sol", "servidor",
        "parado", "galinha", "tormenta",
        "citologia", "averbar", "enganado",
        "catecismo", "arrotar", "consolar",
        "alinhador", "propano", "detalhadamente",
        "arrojar", "absorvimento", "enrugar",
        "clonar", "precedente", "embasado",
        "pejorativo", "ambas", "patinar",
        "exageradamente", "incitador", "vanguarda",
        "poderoso", "calmo", "feio",
        "gostoso", "bonito", "bola",
        "caixote", "felicidade", "sorvete",
        "tenebroso", "colheita", "serpentina",
        "roupa", "natal", "capacete",
        "motorista", "bandeira", "ventilador",
        "computador", "internet", "militar"
        };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
