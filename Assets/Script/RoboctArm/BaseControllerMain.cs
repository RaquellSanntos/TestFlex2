using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControllerMain : MonoBehaviour
{

    /*ROTAÇÃO DA BASE PRINCIPAL COMPLETA DO BRAÇO ROBOTICO
    É permitida o uso do mouse e as setas Direitas e esquerda para movimentação da Base do braço principal*/
    [SerializeField]
    private float vel = 10f;

    void Update()
    {
        float Rotacao = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, 0, Rotacao));
        SetaEsquerda();
        SetaDireita();


    }
    public void SetaDireita()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, vel * Time.deltaTime));
        }


    }
    public void SetaEsquerda()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, -vel* Time.deltaTime));
        }
    }

}
