using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* La clase InicioJugador instancia un personaje jugable basado en el índice recuperado de
PlayerPrefs. */
public class InicioJugador : MonoBehaviour
{
    /// <summary>
    /// La función de inicio crea una instancia de un personaje jugable basado en el índice recuperado de
    /// Preferencias del jugador.
    /// </summary>
    void Start()
    {
        int indexJugador=PlayerPrefs.GetInt("JugadorIndex");
        Instantiate(GameManger.Instance.personajes[indexJugador].personajeJugable,transform.position,Quaternion.identity);
    }
}
