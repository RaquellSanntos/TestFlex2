using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimGarra : MonoBehaviour

{ //Anima��o da Garra (Abrir e Fechar a pin�a)...
    [SerializeField]
    private Animator _Animacao;


    void Start()
    {
        _Animacao = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)|| (Input.GetKey(KeyCode.Alpha1)))
        {
            _Animacao.SetTrigger("Abrir");

        } 
       /* if (Input.GetMouseButtonDown(1))
        {
            _Animacao.SetTrigger("Fechar");
        }*/
    }
}
