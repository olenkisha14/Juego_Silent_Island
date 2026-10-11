using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MesaConf : MonoBehaviour
{
    public static MesaConf Instance;

    [SerializeField] private GameObject mesaOpciones;
    [SerializeField] Image Back;
    [SerializeField] Button button1;
    [SerializeField] Button button2;
    [SerializeField] Button Close;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        mesaOpciones.SetActive(false);
        Back.gameObject.SetActive(false);
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        Close.gameObject.SetActive(false); 
    }

    public void close()
    {
        mesaOpciones.SetActive(false);
        Back.gameObject.SetActive(false);
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        Close.gameObject.SetActive(false);
    }

    public void ToggleMesaOpciones(bool state)
    {
        mesaOpciones.SetActive(state);
        Back.gameObject.SetActive(state);
        if (MenuInicial.Energy == 0 && MenuInicial.Day < 3)
        {
            button1.gameObject.SetActive(state);
        }
        button2.gameObject.SetActive(state);
        Close.gameObject.SetActive(state);
    }

    public void ElegirCulpable()
    {
        SceneManager.LoadScene("(4)ElegirCulpable");
    }

    public void PasarDia()
    {
        SceneManager.LoadScene("PasarDias");
    }


}
