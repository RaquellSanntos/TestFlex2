using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private int cubos =0;

    [SerializeField]
    private Text txt;

    [SerializeField]
    private GameObject Particulas;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CUBO"))
        {
            Destroy (collision.gameObject);
           // object gameObject = (collision.gameObject);
            cubos++;
            txt.text = cubos.ToString();
            Instantiate (Particulas, transform.position, Quaternion.identity);
        }
    }
    
}
