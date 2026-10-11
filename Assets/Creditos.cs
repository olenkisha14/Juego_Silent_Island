using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    public void Regresar()
    {
        SceneManager.LoadScene(1);
    }

    public void Siguiente()
    {
        SceneManager.LoadScene(2);
    }
}
