using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CombustivelPickUp : MonoBehaviour
{
     
   //public GameObject efeitoVisual;
   //Criar efeito e adicionar mais tarde**

   void OnTriggerEnter(Collider other)
   {   
     
     if (other.CompareTag("Player"))
     {
      PickUp(other);
     }

   }

   void PickUp(Collider jogador)
   {
     //** Instantiate(efeitoVisual, transform.position, transform.rotation);

     Player status = jogador.GetComponent<Player>(); 
     status.combustivel += 50;
     Destroy(gameObject);
   }

}
