using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject FimDeJogo, TelaInicial, Bola1, Bola2, Bola3;
    public static int vida;

    void Start()
    {
        Time.timeScale = 1;
        vida = 3;
        Bola1.gameObject.SetActive(true);
        Bola2.gameObject.SetActive(true);
        Bola3.gameObject.SetActive(true);
        FimDeJogo.gameObject.SetActive(false);
        TelaInicial.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {


        switch (vida) //Switch Case com o objetivo de reduzir as "vidas"
        {
            case 3:
                Bola1.gameObject.SetActive(true);
                Bola2.gameObject.SetActive(true);
                Bola3.gameObject.SetActive(true);
                break;

            case 2:
                Bola1.gameObject.SetActive(true);
                Bola2.gameObject.SetActive(true);
                Bola3.gameObject.SetActive(false);
                break;

            case 1:
                Bola1.gameObject.SetActive(true);
                Bola2.gameObject.SetActive(false);
                Bola3.gameObject.SetActive(false);
                break;

            default:
                Bola1.gameObject.SetActive(false);
                Bola2.gameObject.SetActive(false);
                Bola3.gameObject.SetActive(false);
                FimDeJogo.gameObject.SetActive(true);
                TelaInicial.gameObject.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0; // Impossibilitado de se mexer ate apertar para jogar novamente.
                break;
        }
    }

}

