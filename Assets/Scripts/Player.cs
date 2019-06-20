using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public double combustivel = 100; 

    public float valorDecrementoPorTempo = 1;
    private bool travarFuncao = false;

    public CameraShake cameraShake;
    public float ShakeDuracao;
    public float ShakeMagnitude;

    public GameObject RestartButton;
    public GameObject StoreButton;
    public GameObject ImgMenu;
    public GameObject BotaoMoverParaDireita;
    public GameObject BotaoMoverParaEsquerda;


    /**/public FuncionalidadesDaLoja loja;

     IEnumerator DecrementoPorTempo()
     {
        yield return new WaitForSeconds(valorDecrementoPorTempo);
        combustivel = combustivel-0.1;
        travarFuncao = false ;
     }
    
     public void Restart()
     {
       RestartButton.SetActive(true);
       StoreButton.SetActive(true);
       ImgMenu.SetActive(true);
       BotaoMoverParaDireita.SetActive(false);
       BotaoMoverParaEsquerda.SetActive(false);
       Time.timeScale = 0;
     }

     void Awake()
     {
       Time.timeScale = 1;
     }

     void Start()
     {
       StartCoroutine(cameraShake.Shake(ShakeDuracao,ShakeMagnitude));
      
     /**/Debug.Log(loja.referencia);
     }

     void Update()
     {
       StartCoroutine(DecrementoPorTempo());

       if(!travarFuncao)
       {
         travarFuncao = true ;
       }
      
       if(combustivel<=0)
       {
         Restart();
       }
     
    }
    
}

