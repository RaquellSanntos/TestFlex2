using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSimple : MonoBehaviour
{
    public Transform LookCam;
    public Transform CamPosition;
    public float VelocityMoveCam = 5f;


    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, CamPosition.position, VelocityMoveCam * Time.deltaTime);
        this.transform.LookAt(LookCam);

    }
}
