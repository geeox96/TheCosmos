using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionalidadesDaLoja : MonoBehaviour
{

	private int maximoDePontos;

	public static int varEficienciaMotor;

    /**/public int referencia;



    public int getVarEficienciaMotor()
    {
     return varEficienciaMotor;
    }

    public void EficienciaMotorAdicionar(int variavelPolar)
    {

        varEficienciaMotor = varEficienciaMotor + variavelPolar;
        maximoDePontos = maximoDePontos + (variavelPolar * -1);
        Debug.Log("varEficienciaMotor :" + varEficienciaMotor);
        Debug.Log("maximoDePontos :" + maximoDePontos);

    }

    public void	EficienciaMotorRemover(int variavelPolar)
    {
    	EficienciaMotorAdicionar(variavelPolar);
    }

}
