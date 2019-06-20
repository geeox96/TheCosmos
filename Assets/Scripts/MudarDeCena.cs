using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    //public int numeroDeCena;

    public void Jogar()
    {
      SceneManager.LoadScene(1);
    }
}
