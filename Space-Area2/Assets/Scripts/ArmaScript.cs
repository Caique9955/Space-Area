using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour
{
    public GameObject tiroPrefab;
    private bool atirando;


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Tiro();
        }
        else if (Input.GetButton("Jump") && !atirando)
        {
            atirando = true;
            StartCoroutine(Atirar(0.3f));
        }
    }
    IEnumerator Atirar(float t)
    {
        if (atirando)
        {
            Tiro();
        }
        yield return new WaitForSeconds(t);
        atirando = false;
    }
    void Tiro()
    {
        Instantiate(tiroPrefab, transform.position, transform.rotation);
    }
}
