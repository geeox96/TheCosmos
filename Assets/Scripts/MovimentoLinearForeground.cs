using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLinearForeground : MonoBehaviour
{
	public float speed = 15;
    public float destruirObjeto;

    void Start()
    {
      transform.Rotate(0,0,0);
      Destroy(this.gameObject, destruirObjeto );
    }

    void Update()
    {
      transform.Translate(0,0,Time.deltaTime * -speed);
      //Movimento na variavel Z
    }
}
