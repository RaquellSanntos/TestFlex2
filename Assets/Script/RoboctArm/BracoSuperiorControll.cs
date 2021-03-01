using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BracoSuperiorControll : MonoBehaviour
{
    //Controle da cabe�a Principal do bra�o (Subir e descer)
    [SerializeField]
    private float vel = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))//Subir a cabe�a
        {
            transform.Rotate(new Vector3(0, 0, vel * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))//Descer a cabe�a
        {
            transform.Rotate(new Vector3(0, 0, -vel * Time.deltaTime));
        }
    }
}
