using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundoS : MonoBehaviour
{
    public float limite;
    public float retornar;
    void FixedUpdate()
    {
        //Move o pivot do fundo 
        transform.Translate(Vector2.left * Configuracoes.velocidade * Time.deltaTime);

        //Verifica o limite e então retorna
        if (transform.position.x < limite)
        {
            transform.position = new Vector2(retornar, transform.position.y);
        }
    }
}
