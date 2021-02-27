using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class NasCubos : MonoBehaviour
{

    public GameObject prefab;
    public float tempo = 5;
   
 
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo <= 0)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            tempo = 5;
        }
    }
}
