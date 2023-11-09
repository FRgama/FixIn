using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    float speed = 30f; //seta a velocidade da bola
    Rigidbody myrigidbody; //pega os dados do rigidbody inserido na bola (no unity)
    Vector3 velocity;
    
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>(); //puxa a config do rigidbody
        myrigidbody.velocity = Vector3.down*speed; // física do movimento da bola ao iniciar, indo para baixo
    }

    void FixedUpdate() //Lida com a física frame a frame
    {
        myrigidbody.velocity = myrigidbody.velocity.normalized * speed; //normalized -> independente do valor da bola, é normalizado para um valor, no caso 20f
        velocity = myrigidbody.velocity;
    }

     void OnCollisionEnter(Collision collision) //função chamada ao colidir
    {
        myrigidbody.velocity = Vector3.Reflect(velocity, collision.contacts[0].normal); //efeito de "rebote" após a colisão, indo para a direção oposta da que estava...
    } 
}
