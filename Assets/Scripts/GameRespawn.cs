using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    public float Limite;
    private void FixedUpdate()
    {
        if(transform.position.y < Limite) // Caso a bola passe do limite, volta para o ponto inicial e perde um de vida
        {
            transform.position = new Vector3(0f,0f,0f);
            GameManager.vida -= 1;
        }
    }

}
