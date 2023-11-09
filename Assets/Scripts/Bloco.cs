using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public int hits = 1; //hits que voce tem que dar no bloco para destruí-lo
    public Vector3 rotator; //comando para girar
    public Material Batido;
    
    Material orgMaterial;
    Renderer renderer;
    public GameObject FimDeJogo;
    int contablocos;


    void Start()
    {
        transform.Rotate(rotator * (transform.position.x + transform.position.y) * 0.1f);
        renderer = GetComponent<Renderer>();
        orgMaterial = renderer.sharedMaterial;
        contablocos = FindAnyObjectByType<Bloco>().transform.childCount;
    }

    
    void Update()
    {
        transform.Rotate(rotator * Time.deltaTime); //gira por segundo
    }
    
    void OnCollisionEnter(Collision collision) //quando houver colisão hit perde 1, se hit chegar a 0 o objeto é destruido
    {
        hits-=1;
        if (hits <= 0)
        {
            Destroy(gameObject);
            contablocos--;
        }
        renderer.sharedMaterial = Batido; // ao levar um hit (caso tenha 2 ou mais de vida) o objeto fica branco
        Invoke("RestoreMaterial", 0.05f); //após 0.05s chama o restore
        if (contablocos ==0) 
        {
            FimDeJogo.gameObject.SetActive(true);
            Time.timeScale = 0; // Impossibilitado de se mexer até apertar para jogar novamente.
        }
    }

    void RestoreMaterial()
    {
        renderer.sharedMaterial = orgMaterial; //volta o material branco para o padrão
    }
}
