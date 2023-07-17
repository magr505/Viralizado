using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* La línea `opciones de clase pública: MonoBehaviour` está definiendo una nueva clase llamada `opciones` que
hereda de la clase `MonoBehaviour`. Esto significa que la clase `opciones` puede acceder y usar todas
la funcionalidad proporcionada por la clase `MonoBehaviour`, como la capacidad de adjuntar scripts a
objetos de juego en Unity y responden a varios eventos y funciones.*/
public class options : MonoBehaviour
{
    public Canvas cvCerrar, menu, titulo;
    public Button btnCerrar, btnCancelar;
    
    /// <summary>
    /// La función Inicio deshabilita el componente cvCerrar y habilita los componentes de menú y título.
    /// </summary>
    void Start()
    {
        cvCerrar.enabled = false;
        menu.enabled = true;
        titulo.enabled = true;
    }

    /// <summary>
    /// La función "cerrarApp" se utiliza para cerrar la aplicación.
    /// </summary>
    public void cerrarApp()
    {
        Application.Quit();
    }

    /// <summary>
    /// La función "cancelarFin" deshabilita el componente "cvCerrar" y habilita el "menu" y "titulo"
    /// componentes.
    /// </summary>
    public void cancelarFin()
    {
        cvCerrar.enabled = false;
        menu.enabled = true;
        titulo.enabled = true;
    }

    /// <summary>
    /// La función "mostrarVentanaCierre" habilita el componente "cvCerrar" y deshabilita el "menú" y
    /// componentes "título".
    /// </summary>
    public void mostrarVentanaCierre()
    {
        cvCerrar.enabled = true;
        menu.enabled = false;
        titulo.enabled = false;
    }
}
