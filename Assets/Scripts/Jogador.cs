using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour

{
    Rigidbody myrigidbody;  

    void Start()
    {
        Cursor.visible = false; //não mostra o mouse
        myrigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myrigidbody.MovePosition(new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,0,50)).x,-18,0)); //MovePosition = Melhor que translate
        //mouse position -> informa onde o mouse está
        //Camera.Main.ScreenToWorldPoint -> informa a posição do mouse baseada na camera
    }

    public float ParedeEsquerda = -35.15f; 
    public float ParedeDireita = 35.15f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float NovaPosicao = transform.position.x + horizontalInput;

        NovaPosicao = Mathf.Clamp(NovaPosicao, ParedeEsquerda, ParedeDireita);
        transform.position = new Vector3(NovaPosicao, transform.position.y, transform.position.z);
    }
}
