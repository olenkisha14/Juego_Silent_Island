using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;


public class Introduccion : MonoBehaviour
{
    public DialogueRunner dialogueRunner; // Referencia al DialogueRunner

    private void Start()
    {
        // Suscribirse al evento cuando el diálogo termine
        if (dialogueRunner != null)
        {
            dialogueRunner.onDialogueComplete.AddListener(OnDialogueFinished);
        }
    }

    // Método que se llama cuando el diálogo termina completamente
    private void OnDialogueFinished()
    {
        SceneManager.LoadScene(3); // Cambia de escena automáticamente
    }

    public void GoToMap()
    {
        SceneManager.LoadScene(3);
    }
}
