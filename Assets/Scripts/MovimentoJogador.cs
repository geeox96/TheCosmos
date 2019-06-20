using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    Rigidbody foguete;

    void Start()
    {
        foguete = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.touchCount > 0)
        {
            Debug.Log("Working");
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            transform.position = new Vector3(touch.position.x, 0f);      
         
        }
    }
}
