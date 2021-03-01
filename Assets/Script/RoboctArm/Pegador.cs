using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pegador : MonoBehaviour
{
    //ROTAÇÃO DA PINÇA PELO SCROLL DO MOUSE

    void Update()
    {

        float RotGarra = Input.GetAxis("Mouse ScrollWheel");
        transform.Rotate(new Vector3(0, 0, RotGarra));
    }
}
