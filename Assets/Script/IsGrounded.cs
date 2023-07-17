using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* La clase IsGrounded se usa para determinar si un objeto está tocando el suelo actualmente en un 2D
ambiente. */
public class IsGrounded : MonoBehaviour
{
    public static bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision){
        isGrounded = true;
    }
    
    private void OnTriggerExit2D(Collider2D other){
        isGrounded = false;
    }
}