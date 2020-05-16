using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class ProjetilIni : MonoBehaviour
{
    public float velocidade;
    public float tempoVida;
    public GameObject boltPrefab;

    void Start()
    {
        Destroy(gameObject, tempoVida);
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);

       
       
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        GameObject b = Instantiate(boltPrefab, transform.position, transform.rotation);
        Destroy(b, 0.1f);
        if(c.gameObject.tag == "Jogador")
        {
            Destroy(c.gameObject);
        }
        Destroy(gameObject);
    }
}
