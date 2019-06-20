using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLinear : MonoBehaviour
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
      transform.Translate(0, Time.deltaTime * -speed,0);
      //Movimento na variavel Y
    }
}
