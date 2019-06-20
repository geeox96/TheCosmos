using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimenoJogador : MonoBehaviour
{
    public float speed;
	private Rigidbody rbJogador;
    public Vector3 vetorMovimento;

    private int variavelDeControleDePosicao = 0;
    private int limiteMovimento = 2;


   void Start () {rbJogador = GetComponent<Rigidbody>();}

	
   public void movimentoParaDireita()
   {
   	  if(variavelDeControleDePosicao<limiteMovimento)
   	     {
   	     	rbJogador.velocity = transform.right * -speed;
   	     	variavelDeControleDePosicao++;
   	     	}
   	     	else{}
   }

    public void movimentoParaEsquerda()
   {
       if(variavelDeControleDePosicao>-limiteMovimento)
   	     {
   	     	rbJogador.velocity = transform.right * speed;
   	     	variavelDeControleDePosicao--;
   	     	}
   	     	else{}
   }

}
