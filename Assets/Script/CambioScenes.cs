using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CambioScenes : MonoBehaviour
{
   
    /// <summary>
    /// La función "Cambio" carga una nueva escena en Unity usando SceneManager.LoadScene.
    /// </summary>
    public void Cambio()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    /// <summary>
    /// La función "Cambio1" carga la escena número 2 en modo simple usando la clase SceneManager en C#.
    /// </summary>
    public void Cambio1()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
    /// <summary>
    /// La función "Cambio1" carga la escena número 3 en modo simple usando la clase SceneManager en C#.
    /// </summary>
    public void Cambio2()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
    /// <summary>
    /// La función anterior se usa para salir de la aplicación, ya sea deteniendo el editor de Unity o saliendo de la aplicación.
    /// </summary>
    public void exit()
    {
        #if UNITY_EDITOR 
	    UnityEditor.EditorApplication.isPlaying=false;
        #else
        Application.Quit();
        #endif
    }
    /// <summary>
    /// La función verifica si la tecla Escape está presionada y llama a la función exit() si lo está.
    /// </summary>
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            exit();
        }
}
}