using System;
using UnityEngine;

public class SistemaVida: IDanable //Implemnta la interfaz IDanable
{
    private float vidaMaxima = 100f;
    private float vidaActual = 100f;

    // Constructor que establece la vida máxima e inicial
    public SistemaVida(float vidaMaxima)
    {
        this.vidaMaxima = vidaMaxima;
        this.vidaActual = vidaMaxima; // Comienza con vida llena
    }

    // Aplicar daño
    public void RecibirDano(float cantidad)
    {
        vidaActual -= cantidad;
        if (vidaActual < 0)
        {
            vidaActual = 0;
        }
    }

    // Curar
    public void Sanar(float cantidad)
    {

        vidaActual += cantidad;
        if (vidaActual > vidaMaxima)
        {
            vidaActual = vidaMaxima;
        }
    }

    // ¿Sigue con vida?
    public bool GetEstaVivo()
    {
        return vidaActual > 0;
    }

    // Obtener vida actual
    public float GetVidaActual()
    {
        return vidaActual;
    }

    // Obtener vida máxima
    public float GetVidaMaxima()
    {
        return vidaMaxima;
    }

}
