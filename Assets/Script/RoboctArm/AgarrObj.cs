using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrObj : MonoBehaviour
{
    //Pega e solta o objeto cubo 

    public string[] Tags;
    public GameObject ObjPegando;
   // [Space(10)]
   [Range(0,10)]
    public float DistMax;
    public bool Pegando;
    public GameObject Local;
    public LayerMask Layoso;
    //public Transform raio, alvo;
    void Update()
    {
        if (Pegando == true)
        {
            if (Input.GetMouseButtonDown(0)||(Input.GetKeyDown(KeyCode.Alpha1)))
            {
                Pegando = false;
                ObjPegando.transform.parent = null;
                ObjPegando.GetComponent<Rigidbody>().isKinematic = false;
                ObjPegando = null;
                return;
            }
        }
        if (Pegando == false){
            RaycastHit Hit = new RaycastHit();
            if (Physics.Raycast(transform.position, transform.forward, out Hit, DistMax, Layoso, QueryTriggerInteraction.Ignore)){
                Debug.DrawLine(transform.position, Hit.point, Color.green);

                 ObjPegando = Hit.transform.gameObject;
                for (int x = 0; x < Tags.Length; x++)
                {
                    if (Hit.transform.gameObject.tag == Tags[x])
                    {
                        if (Input.GetMouseButtonDown(0)||(Input.GetKeyDown(KeyCode.Alpha1)))//Ao clicar e pressionar o botão esquerdo do mouse
                        {
                            Pegando = true;
                            ObjPegando = Hit.transform.gameObject;
                            if (ObjPegando.GetComponent<Rigidbody>())
                            {
                                ObjPegando.GetComponent<Rigidbody>().isKinematic = true;
                                ObjPegando.transform.position = Local.transform.position;
                                ObjPegando.transform.rotation = Local.transform.rotation;
                                ObjPegando.transform.parent = Local.transform;
                            }
                            return;
                        }
                    }
                }
            }
        }
    }
}
