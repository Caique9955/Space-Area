using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimento : MonoBehaviour
{
    public GameObject explosaoPrefab;
    public float velocidade;
    public float limiteUp, limiteDown;

    void Start()
    {
        transform.position = new Vector2(-2.09f, 0.0f);
    }


    void Update()
    {
        MoverNave();
        if(Configuracoes.vidas <= 0)
        {
            StartCoroutine(Finalizar());
        }
    }

    // Movimento da nave
    void MoverNave()
    {
        float posY = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        transform.Translate(0.0f, posY, 0.0f);

        if (transform.position.y > limiteUp || transform.position.y < limiteDown)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y * -1);
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.tag == "Inimigo")
        {
            Configuracoes.vidas--;
            if (Configuracoes.vidas <= 0)
            {
                StartCoroutine(Finalizar());
            }
        }
        else if (c.collider.tag == "InimigoT")
        {
            Configuracoes.vidas--;
            if(Configuracoes.vidas <= 0)
            {
                StartCoroutine(Finalizar());
            }
        }
        if(c.collider.tag == "Tiro")
        {
            Configuracoes.vidas = Configuracoes.vidas - 4;
            
            
        }

    }
    IEnumerator Finalizar()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene("OverScene");
    }
}
