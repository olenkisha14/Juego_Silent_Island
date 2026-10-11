using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class NextDay : MonoBehaviour
{
    public static NextDay Instance;
    [SerializeField] public Button inocente1;
    [SerializeField] public Button inocente2;
    [SerializeField] public Button inocente3;
    [SerializeField] public Button inocente4;
    [SerializeField] public Button suspect1;
    [SerializeField] public Button suspect2;
    [SerializeField] public Button suspect3;
    [SerializeField] public Button suspect4;
    [SerializeField] public Button DiaSiguiente;
    [SerializeField] public TMP_Text inocente1_Voto;
    [SerializeField] public TMP_Text inocente2_Voto;
    [SerializeField] public TMP_Text inocente3_Voto;
    [SerializeField] public TMP_Text inocente4_Voto;
    [SerializeField] public TMP_Text suspect1_Voto;
    [SerializeField] public TMP_Text suspect2_Voto;
    [SerializeField] public TMP_Text suspect3_Voto;
    [SerializeField] public TMP_Text suspect4_Voto;

    public GameObject[] suspects;
    public GameObject[] innocents;
    public TMP_Text[] suspects_Voto;
    public TMP_Text[] innocents_Voto;

    private int[] votosActuales; // 0 = no votó, 1 = votó inocente, 2 = votó sospechoso
    private bool[] votoRegistrado;

    private void Awake()
    {
        suspects = new GameObject[] { suspect1.gameObject, suspect2.gameObject, suspect3.gameObject, suspect4.gameObject };
        innocents = new GameObject[] { inocente1.gameObject, inocente2.gameObject, inocente3.gameObject, inocente4.gameObject };

        suspects_Voto = new TMP_Text[] { suspect1_Voto, suspect2_Voto, suspect3_Voto, suspect4_Voto };
        innocents_Voto = new TMP_Text[] { inocente1_Voto, inocente2_Voto, inocente3_Voto, inocente4_Voto };
        
        votosActuales = new int[4];      
        votoRegistrado = new bool[4];
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        for (int i = 0; i < 4; i++)
        {
            suspects_Voto[i].text = "0";
            innocents_Voto[i].text = "0";
        }
      
    }
    public void ShowSet(int index)
    {
        for (int i = 0; i < 4; i++)
        {
            suspects[i].SetActive(i == index);
            innocents[i].SetActive(i == index);
            suspects_Voto[i].gameObject.SetActive(i == index);
            innocents_Voto[i].gameObject.SetActive(i == index);
        }
    }
    public void SumarTexto(TMP_Text campo)
    {
        int actual = int.Parse(campo.text);
        campo.text = (actual + 1).ToString();
    }


    private void VerificarVotosCompletos()
    {
        bool todosVotaron = true;

        for (int i = 0; i < 4; i++)
        {
            int votosInocente = 0;
            int votosSospechoso = 0;

            // TryParse evita errores si el texto está vacío o mal formateado
            int.TryParse(innocents_Voto[i].text, out votosInocente);
            int.TryParse(suspects_Voto[i].text, out votosSospechoso);

            if (votosInocente <= 0 && votosSospechoso <= 0)
            {
                todosVotaron = false;
                break;
            }
        }

        DiaSiguiente.interactable = todosVotaron;
        DiaSiguiente.gameObject.SetActive(true);
    }


    public void SiguienteDia()
    {
        MenuInicial.Day += 1;
        MenuInicial.Energy = 5;
        DiaSiguiente.interactable = false; 
        SceneManager.LoadScene(3); 
    }

    public void Votar(int index, bool votoInocente)
    {

        if (MenuInicial.Day > 3) return; // Máximo 3 días
        if (votoRegistrado[index]) return; // Ya votó hoy por este grupo

        if (votoInocente)
        {
            SumarTexto(innocents_Voto[index]);
            votosActuales[index] = 1;
        }
        else
        {
            SumarTexto(suspects_Voto[index]);
            votosActuales[index] = 2;
        }


        votoRegistrado[index] = true;
        VerificarVotosCompletos();
    }


    //// Update is called once per frame
    //void Update()
    //{
    //    if (MenuInicial.Energy == 0)
    //    {
    //        MenuInicial.Day = MenuInicial.Day + 1;
    //        MenuInicial.Energy = 5;
    //    }
    //}

}