using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BracoSuperiorControll : MonoBehaviour
{
    [SerializeField]
    private float vel = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, vel * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, -vel * Time.deltaTime));
        }
    }
}
