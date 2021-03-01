using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGarraController : MonoBehaviour
{
    //CONTROLE DA GARRA: SUBIR E DESCER A PIN�A


    [SerializeField]
    private float vel = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow)) //Desce a pin�a inferior
        {
            transform.Rotate(new Vector3(0, vel * Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.UpArrow))//Sobe a pin�a inferior
        {
            transform.Rotate(new Vector3(0, -vel * Time.deltaTime,0));
        }
    }
}
