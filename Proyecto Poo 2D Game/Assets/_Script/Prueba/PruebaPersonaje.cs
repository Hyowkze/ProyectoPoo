using UnityEngine;

public class PruebaPersonaje : MonoBehaviour
{
    [Header("PLAYER PRINCIPAL")]
    [SerializeField]
    private string namePlayer;
    [SerializeField]
    private int lifePlayer;


    [Header("ENEMIGO")]
    [SerializeField]
    private string nameEnemy;
    [SerializeField]
    private int lifeEnemy;


    
    void Start()
    {
        //Creamos dos personajes distintos
        Personaje heroe = new Personaje(namePlayer, lifePlayer);
        Personaje enemy = new Personaje(nameEnemy, lifeEnemy);
        
        //mostramos sus estados iniciales
        Debug.Log(heroe.ToString());
        Debug.Log(enemy.ToString());

        //Hacemos que el Héroe reciba 30 de daño
        heroe.RecibirDanio(30);
        Debug.Log("DEspués e recibir daño: " + heroe.ToString());
        
    }

    
    void Update()
    {
        
    }
}
