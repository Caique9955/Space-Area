using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expocao : MonoBehaviour
{
    private float inter = 0.5f;
    void Start()
    {
        Destroy(gameObject, inter);
    }

}
