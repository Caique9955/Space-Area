using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorTiro : MonoBehaviour
{
    public GameObject inimigoTiro;
    public float posicaoCima, posicaoBaixo;
    public float tempoMinimo, tempoMaximo;

    void Start()
    {
        StartCoroutine(Gerar2());
    }
    IEnumerator Gerar2()
    {
        yield return new WaitForSeconds(Random.Range(tempoMinimo, tempoMaximo));
        float y = Random.Range(posicaoCima, posicaoBaixo);
        Vector3 posicao = new Vector3(transform.position.x, y, 0.0f);
        Instantiate(inimigoTiro, posicao, transform.rotation);
        StartCoroutine(Gerar2());
    }
}
