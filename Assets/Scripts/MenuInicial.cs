using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public static int Energy;
    public static int Day;

    public void Jugar()
    {
        Energy = 5;
        Day = 1;
        Settings.textPersistence1 = "";
        Settings.textPersistence2 = "";
        Settings.textPersistence3 = "";
        Settings.textPersistence4 = "";
        SceneManager.LoadScene(10);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(8);
    }

}
