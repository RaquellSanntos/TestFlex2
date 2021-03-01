using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cube : MonoBehaviour
{


    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("CHAO"))
        {
            Destroy(gameObject,4);
        }
    }
}
