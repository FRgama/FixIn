using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public int hits = 1;
    public Vector3 rotator;
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
        contablocos = FindObjectsOfType<Bloco>().Length;
    }

    void Update()
    {
        transform.Rotate(rotator * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        hits -= 1;
        if (hits <= 0)
        {
            Destroy(gameObject);
            contablocos--;
        }
        renderer.sharedMaterial = Batido;
        Invoke("RestoreMaterial", 0.05f);
        if (contablocos <= 0 && FimDeJogo != null)
        {
            FimDeJogo.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void RestoreMaterial()
    {
        renderer.sharedMaterial = orgMaterial;
    }
}
