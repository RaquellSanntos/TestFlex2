using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControllerMain : MonoBehaviour
{

    //ROTA��O DA BASE COMPLETA DO BRA�O ROBOTICO

    void Update()
    {
        float Rotacao = Input.GetAxis("Mouse X");
        transform.Rotate (new Vector3(0,0, Rotacao ));
    
    }   
 
}
