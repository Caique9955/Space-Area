using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InimigoS : MonoBehaviour
{
    public GameObject explosaoPrefab;
    public float vMaxima, vMinima;
    private float velo;
    public float posiDestroi;

    void Start()
    {
        velo = Random.Range(vMinima, vMaxima);
    }
    void Update()
    {
        transform.Translate(Vector2.down * velo * Time.deltaTime);
        if (transform.position.x < posiDestroi)
        {
            Destroy(gameObject);
        }
        // Dar dano no jogador quando o inimigo passar da tela
        if(transform.position.x < -3.83)
        {
            Configuracoes.vidas = Configuracoes.vidas - 1;
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag != "Jogador")
        {
            Configuracoes.pontuacao += 10;
            GameObject explosao = Instantiate(explosaoPrefab, transform.position, transform.rotation);
            Destroy(explosao, 0.3f);

            Destroy(gameObject);
        }
        else if (c.gameObject.tag != "InimigoT")
        {
            Configuracoes.pontuacao = 0;
        }
    }
    
}
