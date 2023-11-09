using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartNivel()
    {
        Time.timeScale = 1;
        GameManager.vida = 3;
        SceneManager.LoadScene(1);

    }
}
