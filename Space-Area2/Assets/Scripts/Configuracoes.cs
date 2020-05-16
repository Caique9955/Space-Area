using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Configuracoes : MonoBehaviour
{
    public static float velocidade = 5.0f;
    public static int vidas;
    public static int pontuacao;
    public Text p;
    public Text v;

    void Start()
    {
        vidas = 4;
        pontuacao = 0;
    }
    void Update()
    {
        p.text = "Pontos " + pontuacao.ToString();
        v.text = "Vidas " + vidas.ToString();
    }
}
