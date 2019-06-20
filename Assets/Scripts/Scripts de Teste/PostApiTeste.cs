using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PostApiTeste : MonoBehaviour
{

   public string variavelPost ;

   public void PostApi_T()
   
    {
         StartCoroutine(Upload());
    }

     IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
        form.AddField("pontos", variavelPost);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:3000/posts?id=?", form))
        {
            yield return www.SendWebRequest();
        }
    }   
}
