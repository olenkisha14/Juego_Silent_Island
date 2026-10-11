using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirCulpable : MonoBehaviour
{
    public void ElegirSospechoso1()
    {
        SceneManager.LoadScene("(6)PerderJuego");
    }

    public void ElegirSospechoso2()
    {
        SceneManager.LoadScene("(6)PerderJuego");
    }

    public void ElegirSospechoso3()
    {
        SceneManager.LoadScene("(6)PerderJuego");
    }

    public void ElegirSospechoso4()
    {
        SceneManager.LoadScene("(5)GanarJuego");
    }
}
