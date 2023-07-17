using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* La línea `public class Movimientos : MonoBehaviour` está definiendo una nueva clase llamada `Movimientos`
que hereda de la clase `MonoBehaviour`. Esto significa que la clase `Movimientos` puede acceder y
usar toda la funcionalidad provista por la clase `MonoBehaviour`, como el método `Start()` y
la capacidad de adjuntar scripts a los objetos del juego en Unity. */
public class Movimientos : MonoBehaviour
{
    //atributos de la clase
    public float velocidadCorrer = 5;
    public float velocidadSaltar = 10;

    Rigidbody2D rb2D;
    
    //botones
    public Button btnLeft, btnRight;

    
    
    /// <summary>
    /// La función Inicio asigna el componente Rigidbody2D a la variable rb2D.
    /// </summary>
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// La función "irDerecha" establece la velocidad del objeto rb2D para moverse hacia la derecha con un
    /// velocidad de carrera especificada.
    /// </summary>
    public void irDerecha()
    {
        rb2D.velocity = new Vector2(velocidadCorrer, rb2D.velocity.y);
    }
    /// <summary>
    /// La función "irIzquierda" establece la velocidad de un cuerpo rígido 2D para moverse hacia la izquierda con un
    /// velocidad de carrera especificada.
    /// </summary>
    public void irIzquierda()
    {
        rb2D.velocity = new Vector2(-velocidadCorrer, rb2D.velocity.y);
    }
     
   /// <summary>
   /// La función "saltar" permite que el personaje del jugador salte si está conectado a tierra.
   /// </summary>
   public void saltar()
   {
        if(IsGrounded.isGrounded)
        {
        rb2D.velocity = new Vector2(rb2D.velocity.x, velocidadSaltar);
        }
   }
}

