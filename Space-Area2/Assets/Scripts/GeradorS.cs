using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorS : MonoBehaviour
{
    public GameObject inimigoPrefab;
    public float posicaoCima, posicaoBaixo;
    public float tempoMinimo, tempoMaximo;

    void Start()
    {
        StartCoroutine(Gerar());
    }
    IEnumerator Gerar()
    {
        yield return new WaitForSeconds(Random.Range(tempoMinimo, tempoMaximo));
        float y = Random.Range(posicaoCima, posicaoBaixo);
        Vector3 posicao = new Vector3(transform.position.x, y, 0.0f);
        Instantiate(inimigoPrefab, posicao, transform.rotation);
        StartCoroutine(Gerar());
    }
}
