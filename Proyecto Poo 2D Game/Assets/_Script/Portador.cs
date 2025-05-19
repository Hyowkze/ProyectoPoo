using UnityEngine;

public abstract class Portador 
{
    protected SistemaVida sistemaVida;

    // Constructor
    public Portador(float vidaInicial)
    {
        sistemaVida = new SistemaVida(vidaInicial);
    }

    // M�todo para recibir da�o
    public void RecibirDano(float cantidadDano)
    {
        sistemaVida.RecibirDano(cantidadDano);

        if (!sistemaVida.GetEstaVivo())
        {
            ManejarMuerte();
        }
    }

    // M�todo para sanar
    public void Sanar(float cantidadSanar)
    {
        sistemaVida.Sanar(cantidadSanar);
    }

    // Obtener si est� vivo
    public bool getEstaVivo()
    {
        return sistemaVida.GetEstaVivo();
    }

    // Obtener vida actual
    public float getVidaActual()
    {
        return sistemaVida.GetVidaActual();
    }

    // Obtener vida m�xima
    public float getVidaMaxima()
    {
        return sistemaVida.GetVidaMaxima();
    }

    // M�todo abstracto para manejar la muerte (debe implementarse en clases hijas)
    public abstract void ManejarMuerte();

}
