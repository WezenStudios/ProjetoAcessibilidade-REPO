using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public AudioClip[] sonsBotao; // Adiciona os sons correspondentes aos bot�es no Editor

    private void BotaoClicado(int botaoIndex)
    {
        if (botaoIndex >= 0 && botaoIndex < sonsBotao.Length)
        {
            StartCoroutine(TocarSomETrocarCena(sonsBotao[botaoIndex].length, botaoIndex + 1));
        }
        else
        {
            Debug.LogError("�ndice de bot�o inv�lido");
        }
    }

    private IEnumerator TocarSomETrocarCena(float duracaoSom, int proximaCenaIndex)
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>(); // Adiciona um novo AudioSource

        audioSource.PlayOneShot(sonsBotao[proximaCenaIndex - 1]);

        yield return new WaitForSeconds(duracaoSom);

        SceneManager.LoadScene(proximaCenaIndex);
        Destroy(audioSource); // Destroi o AudioSource ap�s o uso
    }
}
