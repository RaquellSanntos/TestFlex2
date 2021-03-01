using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Sair : MonoBehaviour
    //SAIR DO JOGO
{
    [SerializeField]
    private bool btnSair;

    void Update()
    {
        if (btnSair==false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                Application.Quit();

        }
    }
}
