using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tela : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(Cenas()); 
    }

    
    IEnumerator Cenas()
    {
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene("GameScene");
    }
}
