using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGarraController : MonoBehaviour
{
    //cONTROLE DA GARRA: SUBIR E DESCER A PINÇA


    [SerializeField]
    private float vel = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, vel * Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -vel * Time.deltaTime,0));
        }
    }
}
