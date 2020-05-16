using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaInimigo : MonoBehaviour
{
    public GameObject tiroInimigoPrefab;
    

    void Start()
    {
        StartCoroutine(Atirando());
    }

    
    void Update()
    {
        
    }
    IEnumerator Atirando()
    {
        Instantiate(tiroInimigoPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(5.0f);
        StartCoroutine(Atirando());
    }
}
