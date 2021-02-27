using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimGarra : MonoBehaviour
{ //Animação da Garra...
    [SerializeField]
    private Animator _Animacao;


    void Start()
    {
        _Animacao = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _Animacao.SetTrigger("Abrir");

        } if (Input.GetMouseButtonDown(1))
        {
            _Animacao.SetTrigger("Fechar");
        }
    }
}
