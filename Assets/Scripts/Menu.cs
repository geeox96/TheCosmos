using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Jogar()
    {
      Time.timeScale = 1;
      SceneManager.LoadScene("TelaJogando");
    }

    

    public void FecharJogo()
    {
      Debug.Log("Fechou!");
      Application.Quit();
    }

}
