using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnCombustivel : MonoBehaviour
{

   public Transform SpawnEsquerda; //Locais de Spawn do combustivel
   public Transform SpawnCentro;
   public Transform SpawnDireita;

   public GameObject ObjetoSpwan;

   public float SpawnTempoInicio;    //Tempo ate combustivel comecar a Spawnar
   public float SpawnTempoPeriodico; //De xSegundos em xSegundos, Spawna combustivel
   public float UnSpawnTempo;        //Tempo ate o objeto ser destruido
  
    void Spawn()
    {
 
      int range = Random.Range(1,4); //Sorteia numeros de 1 a 3

      if(range == 1) //Spawna combustivel
      {
         GameObject SpawnAuxiliar;
   
         SpawnAuxiliar = Instantiate(ObjetoSpwan, SpawnEsquerda.position, SpawnEsquerda.rotation);
   
         Destroy(SpawnAuxiliar, UnSpawnTempo);
       }

        if(range == 2) //Spawna combustivel
        {
         GameObject SpawnAuxiliar;
   
         SpawnAuxiliar = Instantiate(ObjetoSpwan, SpawnCentro.position, SpawnCentro.rotation);
   
         Destroy(SpawnAuxiliar, UnSpawnTempo);
       }

        if(range == 3) //Spawna combustivel
        {
         GameObject SpawnAuxiliar;
   
         SpawnAuxiliar = Instantiate(ObjetoSpwan, SpawnDireita.position, SpawnDireita.rotation);
   
         Destroy(SpawnAuxiliar, UnSpawnTempo);
       }


    }


    void Start()
    {
       InvokeRepeating("Spawn",SpawnTempoInicio,SpawnTempoPeriodico); 
        //Envoca a funcao Span repetidas vezes
    }

    void Update()
    {

    }
    

}
