using UnityEngine;

public interface IDanable 
{
    public void RecibirDano(float cantidad);

    public void Sanar(float cantidad);
    public bool GetEstaVivo();


}
