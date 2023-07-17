using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    //lista que almacena los personajes
    public List<Personajes> personajes; 
    /// <summary>
    /// Esta función garantiza que solo haya una instancia del objeto GameManger en la escena y
    /// evita que se destruya al cargar nuevas escenas.
    /// </summary>
    private void Awake()
    {
        //instancia del objeto
        //si en la escena no existe la instancia del objeto
        //hecemos que se haga higual a si misma
        if(GameManger.Instance==null)
        {
            GameManger.Instance=this;
            //DontDestryOnLoad lo utilizamos para poder pasar entre escenas
            DontDestroyOnLoad(this.gameObject);
        }
        //si ya existe hacemos que se destruya
        else
        {
            Destroy(gameObject);
        }
    }
}
