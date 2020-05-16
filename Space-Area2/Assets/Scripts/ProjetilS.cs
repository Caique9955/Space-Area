using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilS : MonoBehaviour
{
    public float velocidade;
    public float tempoDeVida;
    public GameObject boltPrefab;
    void Start()
    {
        Destroy(gameObject, tempoDeVida);
    }

    void Update()
    {
        transform.Translate(Vector2.up * velocidade * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        GameObject b = Instantiate(boltPrefab, transform.position, transform.rotation);
        Destroy(b, 0.1f);
        if (c.gameObject.tag == "Inimigo")
        {
            Destroy(c.gameObject);
        }
        else if(c.gameObject.tag == "InimigoT")
        {
            Destroy(c.gameObject);
        }
        Destroy(gameObject);
    }
}
