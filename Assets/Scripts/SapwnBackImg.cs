using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapwnBackImg : MonoBehaviour
{
   public Transform Spawn;
   public GameObject ObjetoSpawn;

   public float SpawnTempoInicio;
   public float SpawnTempoPeriodico;
   public float UnSpawnTempo;
  
   void SpawnBack() //Spawna a imagem de fundo, fica em loop no "void Start"
   {
   	     GameObject SpawnAuxiliar;
   
         SpawnAuxiliar = Instantiate(ObjetoSpawn, Spawn.position, Spawn.rotation);
   
         Destroy(SpawnAuxiliar, UnSpawnTempo);
   }

    void Start()
    {
       InvokeRepeating("SpawnBack",SpawnTempoInicio,SpawnTempoPeriodico); 
        //Envoca a funcao SpawnBack repetidas vezes
    }
}
