using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoJogar : MonoBehaviour
{
    private const string SceneName = "SampleScene";

    public void Jogar()
    {
        SceneManager.LoadScene(SceneName);
    }
}
