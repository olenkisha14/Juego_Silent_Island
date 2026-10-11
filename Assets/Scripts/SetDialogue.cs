using System.Collections;
using System.Collections.Generic;
using Yarn.Unity;
using UnityEngine;
using Unity.VisualScripting;
using Yarn;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using System.Runtime.ConstrainedExecution;
using System;
using UnityEngine.UIElements;

public class SetDialogue : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;
    private bool exit = false;

    // Start is called before the first frame update
    void Start()
    {
        int recievedDay = MenuInicial.Day;
        int recievedHouse = DangerZone.House;
        switch (recievedDay)
        {
            case 1:
                if (recievedHouse == 1)
                {
                    runner.StartDialogue("Dia1A_Pregunta1");
                }
                else if(recievedHouse == 2)
                {
                    runner.StartDialogue("Dia1B_Pregunta1");
                }
                else if (recievedHouse == 3)
                {
                    runner.StartDialogue("Dia1C_Pregunta1");
                }
                else
                {
                    runner.StartDialogue("Dia1D_Pregunta1");
                }
                break;

            case 2:
                if (recievedHouse == 1)
                {
                    runner.StartDialogue("Dia2A_Pregunta1");
                }
                else if (recievedHouse == 2)
                {
                    runner.StartDialogue("Dia2B_Pregunta1");
                }
                else if (recievedHouse == 3)
                {
                    runner.StartDialogue("Dia2C_Pregunta1");
                }
                else
                {
                    runner.StartDialogue("Dia2D_Pregunta1");
                }
                break;

            case 3:
                if (recievedHouse == 1)
                {
                    runner.StartDialogue("Dia3A_Pregunta1");
                }
                else if (recievedHouse == 2)
                {
                    runner.StartDialogue("Dia3B_Pregunta1");
                }
                else if (recievedHouse == 3)
                {
                    runner.StartDialogue("Dia3C_Pregunta1");
                }
                else
                {
                    runner.StartDialogue("Dia3D_Pregunta1");
                }
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (exit)
        {
           
        }

    }
}
