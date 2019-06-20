using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
 
   public IEnumerator Shake (float duracao, float magnitude)
   {
   
      Vector3 posicaoOriginal = transform.localPosition;

      float elapsed = 0;
    
       
      while (elapsed < duracao) //Faz a camera tremer por determinada duracao
      {
 
    	 float x = Random.Range(-1f, 1f) * magnitude;
    	 float y = Random.Range(-1f, 1f) * magnitude;

    	 transform.localPosition = new Vector3(x,y,posicaoOriginal.z);

         elapsed += Time.deltaTime;

         yield return null;
      }

      transform.localPosition = posicaoOriginal; 

   }

}
