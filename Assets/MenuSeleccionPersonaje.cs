using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccionPersonaje : MonoBehaviour
{
   private int index;
   [SerializeField] private Image imagen;
   [SerializeField] private TextMeshProUGUI nombre;
   private GameManger gameManager;

   /// <summary>
   /// La función de inicio inicializa GameManager, recupera el índice del jugador de
   /// PlayerPrefs, y llama a la función CambiarPantalla.
   /// </summary>
   private void Start(){
    gameManager = GameManger.Instance;
    index = PlayerPrefs.GetInt("JugadorIndex");
    if(index>gameManager.personajes.Count-1)
    {
        index=0;
    }
    CambiarPantalla();
   }
   /// <summary>
   /// La función "CambiarPantalla" establece el índice del jugador, actualiza la imagen y el nombre que se muestra en la
   /// pantalla.
   /// </summary>
   private void CambiarPantalla(){
    PlayerPrefs.SetInt("JugadorIndex",index);
    imagen.sprite=gameManager.personajes[index].imagen;
    nombre.text=gameManager.personajes[index].nombre;
   }
   /// <summary>
   /// La función "siguientePersonaje" incrementa el índice del personaje actual en un juego y
   /// cambia la pantalla en consecuencia.
   /// </summary>
   public void siguientePersonaje(){
    if(index == gameManager.personajes.Count - 1)
    {
        index=0;
    }
    else
    {
        index += 1;
    }
    CambiarPantalla();
   }
   /// <summary>
   /// La función "Personaje Anterior" se utiliza para navegar al personaje anterior en un juego,
   /// actualizando el índice y cambiando la pantalla en consecuencia.
   /// </summary>
   public void AnteriorPersonaje(){
    if(index == 0)
    {
        index = gameManager.personajes.Count - 1;
    }
    else
    {
        index -= 1;
    }
    CambiarPantalla();
   }

   /// <summary>
   /// La función "IniciarJuego" carga la siguiente escena del juego.
   /// </summary>
   public void IniciarJuego(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
}
