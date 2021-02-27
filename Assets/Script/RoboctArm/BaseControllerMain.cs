using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControllerMain : MonoBehaviour
{

    //ROTAÇÃO DA BASE COMPLETA DO BRAÇO ROBOTICO

    void Update()
    {
        float Rotacao = Input.GetAxis("Mouse X");
        transform.Rotate (new Vector3(0,0, Rotacao ));
    
    }   
 
}
