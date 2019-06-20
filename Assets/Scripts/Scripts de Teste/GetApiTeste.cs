using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class GetApiTeste : MonoBehaviour
{

    
    public void GetApi_T()
    {
          
    	StartCoroutine(GetRequest("http://localhost:3000/posts"));

    }

   IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
          yield return webRequest.SendWebRequest();
        }

    }

}
