using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BracoMainController : MonoBehaviour
{
    //CONTROLE DO BRAÇO PRINCIPAL, SOBE E DESCE (Rotação no eixo Z).

    [SerializeField]
    private float vel = 10f;

  
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, 0, vel * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, -vel * Time.deltaTime));
        }
    }
}
