using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BracoSuperiorControll : MonoBehaviour
{
    //Controle da cabeça Principal do braço (Subir e descer)
    [SerializeField]
    private float vel = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))//Subir a cabeça
        {
            transform.Rotate(new Vector3(0, 0, vel * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))//Descer a cabeça
        {
            transform.Rotate(new Vector3(0, 0, -vel * Time.deltaTime));
        }
    }
}
