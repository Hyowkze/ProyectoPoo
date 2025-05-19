using UnityEngine;

public abstract class Portador 
{
    protected SistemaVida sistemaVida;

    // Constructor
    public Portador(float vidaInicial)
    {
        sistemaVida = new SistemaVida(vidaInicial);
    }

    // Método para recibir daño
    public void RecibirDano(float cantidadDano)
    {
        sistemaVida.RecibirDano(cantidadDano);

        if (!sistemaVida.GetEstaVivo())
        {
            ManejarMuerte();
        }
    }

    // Método para sanar
    public void Sanar(float cantidadSanar)
    {
        sistemaVida.Sanar(cantidadSanar);
    }

    // Obtener si está vivo
    public bool getEstaVivo()
    {
        return sistemaVida.GetEstaVivo();
    }

    // Obtener vida actual
    public float getVidaActual()
    {
        return sistemaVida.GetVidaActual();
    }

    // Obtener vida máxima
    public float getVidaMaxima()
    {
        return sistemaVida.GetVidaMaxima();
    }

    // Método abstracto para manejar la muerte (debe implementarse en clases hijas)
    public abstract void ManejarMuerte();

}
