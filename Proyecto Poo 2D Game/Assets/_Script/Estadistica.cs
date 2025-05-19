using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Estadistica
{

    [SerializeField]
    private float valorMaximo; //Valor salud 100
    [SerializeField] 
    private float valorActual; //Valor actualizaci�n energia

    //Tabla de estadistica de la energia
    public void Estadisticas (float valormaximoIncial, float valorActualInicial) 
    {
        valorMaximo = valormaximoIncial;
        valorActual = valorActualInicial;

        //correciones de chat
        //valorMaximo = valorMaximoInicial;
        //valorActual = Mathf.Clamp(valorActualInicial, 0, valorMaximo);

    }

    //Funci�n para conseguir el valor actual de la energia
    public float GetValorActual()
    {
        return valorActual;
 
    }

    //Funci�n para establecer el valor limite de la energia
    public void SetValorActual(float nuevoValorLim) 
    {
        valorActual = Mathf.Clamp(nuevoValorLim, 0, valorMaximo);

       

    }


    //Funci�n para obtener el valor m�ximo de la energia
    public float GetValorMaximo() 
    {
        return valorMaximo;
    }

    //Funci�n para establecer el valor m�ximo
    public void SetValorMaximo(float nuevoValorMax)
    {
        valorMaximo = nuevoValorMax;
    }


    //Incrementar energia 
    public void Incrementar(float ManaIncrement) 
    {
        ManaIncrement += 5;
    
    }

    //Perdida de energia
    public void Decrementar(float ManaDecrement)
    {    
        ManaDecrement -= 10;
    }
      


        


    




    
}
