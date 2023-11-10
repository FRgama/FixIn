using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoJogar : MonoBehaviour
{
    private const string SceneName = "SampleScene";

    public void Jogar()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Creditos()
    {
        SceneManager.LoadScene(2);
    }
}
