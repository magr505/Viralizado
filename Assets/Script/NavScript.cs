using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

/* La línea `clase pública NavScript: MonoBehaviour` define una clase pública llamada `NavScript` que
hereda de la clase `MonoBehaviour`. Esto significa que `NavScript` se puede adjuntar a un juego
object en Unity y puede tener su propia funcionalidad y comportamiento personalizados. */
public class NavScript : MonoBehaviour
{
    public Text btnNavegacion;
    public string escena;

    /// <summary>
    /// La función "gotoScene" carga una nueva escena en Unity usando la clase SceneManager.
    /// </summary>
    public void gotoScene(){
        SceneManager.LoadScene(escena);
    } 
}
