using System.Collections;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private GameObject dialogueMark;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(4,10)] private string[] dialogueLines;
    
    private float typinTime = 0.20f;
    private bool isplayerInRange;
    private bool didDialogueStart;
    private int lineIndex;

    
    /// <summary>
    /// La función verifica si el jugador está dentro del alcance y ha presionado el botón "Disparar1", y luego
    /// inicia el diálogo si aún no ha comenzado, o pasa a la siguiente línea de diálogo si el
    /// la línea actual ha terminado de mostrarse, o detiene todas las corrutinas y muestra la línea actual si
    /// todavía se muestra.
    /// </summary>
    void Update()
    {
        if(isplayerInRange && Input.GetButtonDown("Fire1"))
        {
            if(!didDialogueStart)
            {
                StartDialogue();
            }
            else if(dialogueText.text == dialogueLines[lineIndex])
            {
                NextDialogueline();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = dialogueLines[lineIndex];
            }
        }
    }

    /// <summary>
    /// La función StartDialogue inicia un diálogo configurando ciertas variables, activando un diálogo
    /// panel, ocultar una marca de diálogo, establecer el índice de línea en 0, pausar el juego e iniciar un
    /// rutina para mostrar la línea de diálogo.
    /// </summary>
    private void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        dialogueMark.SetActive(false);
        lineIndex = 0;
         Time.timeScale = 0f;
        StartCoroutine(ShowLine());
    }

    /// <summary>
    /// La función incrementa el índice de línea, verifica si hay más líneas de diálogo y
    /// muestra la línea siguiente u oculta el panel de diálogo y muestra la marca de diálogo.
    /// </summary>
    private void NextDialogueline()
    {
        lineIndex++;
        if(lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            dialogueMark.SetActive(true);
             Time.timeScale = 1f;
        }
    }

   /// <summary>
   /// La función ShowLine muestra una línea de diálogo carácter por carácter con una escritura específica
   /// tiempo.
   /// </summary>
    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typinTime);
        }
    }

    /// <summary>
    /// Esta función se activa cuando un colisionador 2D entra en otro colisionador, y si el colisionador
    /// pertenece al jugador, establece una variable booleana en verdadero y activa un marcador de diálogo.
    /// </summary>
    /// <param name="Collider2D">El método OnTriggerEnter2D es un método de devolución de llamada de Unity que se llama
    /// cuando un colisionador 2D entra en un colisionador disparador. El parámetro "colisión" es el colisionador que
    /// ingresó al disparador colisionador.</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isplayerInRange = true;
            dialogueMark.SetActive(true);
            //Debug.Log("se puede iniciar un dialogo");
        }
        
    }

    /// <summary>
    /// Esta función se activa cuando un colisionador sale del área de activación y si el colisionador pertenece
    /// al jugador, establece una variable booleana en falso, oculta un marcador de diálogo y registra un mensaje.
    /// </summary>
    /// <param name="Collider2D">El parámetro "colisión" es de tipo Collider2D. representa el
    /// componente colisionador del objeto que salió del activador.</param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isplayerInRange = false;
            dialogueMark.SetActive(false);
            //Debug.Log("saliendo del rango");
        }
    }


}
