using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class DangerZone : MonoBehaviour
{

    [SerializeField] private SpriteRenderer targetSprite;

    [SerializeField] private int zoneId = 1; // Asigna del 1 al 5 en el Inspector

    public static int House;

    //public bool pressBoton = true;

    private bool playerInside = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log(MenuInicial.Energy);
            playerInside = true;
            targetSprite.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (targetSprite != null)
            {
                playerInside = false;
                targetSprite.gameObject.SetActive(false);
            }
            if (zoneId == 5)
            {
                MesaConf.Instance.ToggleMesaOpciones(false);
            }
        }
    }

    private void Update()
    {
        if (!playerInside) return;

        if ((zoneId >= 1 && zoneId <= 4) && Input.GetKeyDown(KeyCode.E))
        {
            
            switch (gameObject.name)
            {
                case "House1":
                    House = 1;
                    break;
                case "House2":
                    House = 2;
                    break;
                case "House3":
                    House = 3;
                    break;
                case "House4":
                    House = 4;
                    break;
            }
            SceneManager.LoadScene("(3)Casa");
            
        }
        else if (zoneId == 5 && Input.GetKeyDown(KeyCode.C) && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("(2)Mapa"))
        {
            House = 5;
            MesaConf.Instance.ToggleMesaOpciones(true);
        }
       
    }

    
}


