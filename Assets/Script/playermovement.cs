using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* La línea `public class playermovement: MonoBehaviour` está definiendo una nueva clase llamada
`playermovement` que hereda de la clase `MonoBehaviour`. Esto significa que el `movimiento del jugador`
puede acceder y usar toda la funcionalidad provista por la clase `MonoBehaviour`, como el
Métodos `Start()` y `Update()`. */
public class playermovement : MonoBehaviour
{

    float horizontalMove = 0, verticalMove = 0;
    public float runSpeedHorizontal = 2, runSpeedVertical = 3, runSpeed = 1, jumpForce = 3;

    Rigidbody2D rigidbody2D;
    public Joystick joystick;

    public Button saltar;


    
   /// <summary>
   /// La función de inicio asigna el componente Rigidbody2D del objeto de juego actual al
   /// variable rigidbody2D.
   /// </summary>
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

   /// <summary>
   /// La función Actualizar actualiza la posición del objeto en función de la entrada de un joystick.
   /// </summary>
    void Update()
    {
        //verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime * runSpeed;
    }

   /// <summary>
   /// La función "saltar" permite que el personaje del jugador salte si actualmente está conectado a tierra.
   /// </summary>
    public void jump(){
        if(IsGrounded.isGrounded){
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
        }
       // gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}
