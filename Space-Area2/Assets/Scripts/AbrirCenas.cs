using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirCenas : MonoBehaviour
{
    private string cena;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("TutorialScene");

        }
    }
}
