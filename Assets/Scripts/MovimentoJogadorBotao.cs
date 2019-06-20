using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentoJogadorBotao : MonoBehaviour
{

    
    public float velocidade;
   
    void Update()
    {
        Movimento();
    }

    public void Movimento()
    {
        transform.Translate(0, +velocidade, 0);
    }

}
