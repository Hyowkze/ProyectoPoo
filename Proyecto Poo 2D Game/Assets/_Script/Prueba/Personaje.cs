using UnityEngine;


public class Personaje 
{
    public string nombre;
    public int vida; 


    //Constructor: Se llama al crear un nuevo Personaje
    public Personaje (string nombreInicial, int vidaInicial)
    {
        nombre = nombreInicial;
        vida = vidaInicial; 
    }


    public void RecibirDanio( int cantidad)
    {
        vida -= cantidad;
        if (vida < 0) vida = 0;
        Debug.Log (nombre + "recibio daño. Vida restante: " + vida);


    }

    //Metodo para mostrar info por consola
    public override string ToString()
    {
        return $"[{nombre}] Vida: {vida}";

    }

}






