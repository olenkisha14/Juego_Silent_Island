using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Yarn.Unity;

public class Settings : MonoBehaviour
{
    [SerializeField] Image Image1;
    
    [SerializeField] Image BackCards;
    [SerializeField] Button button;
    [SerializeField] Button button2;
    [SerializeField] TMP_Text sospechoso1;
    [SerializeField] TMP_Text sospechoso2;
    [SerializeField] TMP_Text sospechoso3;
    [SerializeField] TMP_Text sospechoso4;
    [SerializeField] TMP_Text card1;
    [SerializeField] TMP_Text card2;
    [SerializeField] TMP_Text card3;
    [SerializeField] TMP_Text card4;
    [SerializeField] public PostDialogueData NCP1_PostDialogueData;
    [SerializeField] public PostDialogueData NCP2_PostDialogueData;
    [SerializeField] public PostDialogueData NCP3_PostDialogueData;
    [SerializeField] public PostDialogueData NCP4_PostDialogueData;
    [SerializeField] Button siguiente1;
    [SerializeField] Button siguiente2;
    [SerializeField] Button siguiente3;
    [SerializeField] Button antes1;
    [SerializeField] Button antes2;
    [SerializeField] Button antes3;
    [SerializeField] DialoguePresenterBase dialoguePresenterBase;
    [SerializeField] DialoguePresenterBase dialoguePresenterBase2;
    public static string textPersistence1;
    public static string textPersistence2; 
    public static string textPersistence3;
    public static string textPersistence4;
    private float currentEnergy;
    int HouseUpdated;

    public static Settings Instance { get; private set; }

    private void Awake()
    {
        card1.text = textPersistence1;
        card2.text = textPersistence2;
        card3.text = textPersistence3;
        card4.text = textPersistence4;
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    public void SetCardText(int index, string newText)
    {
        TMP_Text targetCard = null;

        switch (index)
        {
            case 0:
                targetCard = card1;
                break;
            case 1: targetCard = card2; break;
            case 2: targetCard = card3; break;
            case 3: targetCard = card4; break;
        }

        if (targetCard != null)
        {
            if (!string.IsNullOrWhiteSpace(targetCard.text))
            {
                switch(index)
                {
                    case 0: 
                        textPersistence1 = textPersistence1 + "\n\n" + newText;
                        targetCard.text = textPersistence1; 
                        break;
                    case 1: 
                         textPersistence2 = textPersistence2 + "\n\n" + newText;
                        targetCard.text = textPersistence2;
                        break;
                    case 2:
                        textPersistence3 = textPersistence3 + "\n\n" + newText;
                        targetCard.text = textPersistence3;
                        break;
                    case 3:
                        textPersistence4 = textPersistence4 + "\n\n" + newText;
                        targetCard.text = textPersistence4;
                        break;
                }
              
            }
            else
            {
                switch (index)
                {
                    case 0:
                        textPersistence1 = textPersistence1 + newText;
                        targetCard.text = textPersistence1;
                        break;
                    case 1:
                        textPersistence2 = textPersistence2 + newText;
                        targetCard.text = textPersistence2;
                        break;
                    case 2:
                        textPersistence3 = textPersistence3 + newText;
                        targetCard.text = textPersistence3;
                        break;
                    case 3:
                        textPersistence4 = textPersistence4 + newText;
                        targetCard.text = textPersistence4;
                        break;
                }
                
            }
        }
    }

    public void Cards()
    {
        Image1.gameObject.SetActive(true);
        BackCards.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(true);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(true);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(true);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(false);
        if (dialoguePresenterBase.isActiveAndEnabled)
        {
            dialoguePresenterBase.gameObject.SetActive(false);
        }
        if (dialoguePresenterBase2.isActiveAndEnabled)
        {
            dialoguePresenterBase2.gameObject.SetActive(false);
        }
    }
    public void siguiente_1()
    {
    
        BackCards.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(true);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(true);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(false);  
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(true); 
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(true);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(true);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(false);
    }

    public void siguiente_2()
    {
        Image1.gameObject.SetActive(true);
        BackCards.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(true);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(true);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(true);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(true);
        antes3.gameObject.SetActive(false);
    }


    public void siguiente_3()
    {
        Image1.gameObject.SetActive(true);
        BackCards.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(true);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(true);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(true);
    }

    public void antes_1()
    {

        BackCards.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(true);
        sospechoso1.gameObject.SetActive(true);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(true);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(true);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(false);
    }

    public void antes_2()
    {

        BackCards.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(true);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(true);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(true);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(true);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(true);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(false);
    }

    public void antes_3()
    {

        Image1.gameObject.SetActive(true);
        BackCards.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(true);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(true);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(true);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(true);
        antes3.gameObject.SetActive(false);
    }

    public void Close_Cards()
    {
        Image1.gameObject.SetActive(false);
        BackCards.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button.gameObject.SetActive(true);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(false);
        if (dialoguePresenterBase)
        {
            dialoguePresenterBase.gameObject.SetActive(true);
        }
        if (dialoguePresenterBase2)
        {
            dialoguePresenterBase2.gameObject.SetActive(true);
        }

    }


    public void d_siguiente_1()
    {

        BackCards.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(true);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(true);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(true);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(true);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(false);
        NextDay.Instance.ShowSet(1);
    }

    public void d_siguiente_2()
    {
        BackCards.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(true);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(true);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(true);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(true);
        antes3.gameObject.SetActive(false);
        NextDay.Instance.ShowSet(2);
    }


    public void d_siguiente_3()
    {
        BackCards.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(true);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(true);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(true);
        NextDay.Instance.ShowSet(3);
    }

    public void d_antes_1()
    {

        BackCards.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(true);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(true);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(true);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(false);
        NextDay.Instance.ShowSet(0);
    }

    public void d_antes_2()
    {

        BackCards.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(true);
        sospechoso3.gameObject.SetActive(false);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(true);
        card3.gameObject.SetActive(false);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(true);
        siguiente3.gameObject.SetActive(false);
        antes1.gameObject.SetActive(true);
        antes2.gameObject.SetActive(false);
        antes3.gameObject.SetActive(false);
        NextDay.Instance.ShowSet(1);
    }

    public void d_antes_3()
    {

        BackCards.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        Image1.gameObject.SetActive(false);
        sospechoso1.gameObject.SetActive(false);
        sospechoso2.gameObject.SetActive(false);
        sospechoso3.gameObject.SetActive(true);
        sospechoso4.gameObject.SetActive(false);
        card1.gameObject.SetActive(false);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(true);
        card4.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(false);
        siguiente3.gameObject.SetActive(true);
        antes1.gameObject.SetActive(false);
        antes2.gameObject.SetActive(true);
        antes3.gameObject.SetActive(false);
        NextDay.Instance.ShowSet(2);
    }


    [Yarn.Unity.YarnCommand("unlock_card")]
    public static void UnlockCard(string npcId, int index)
    {
        string text = "";
        switch (npcId)
        {
            case "NCP1":
                text = Instance.NCP1_PostDialogueData.postDialogueData[index];
                Instance.SetCardText(0, text);
                break;
            case "NCP2":
                text = Instance.NCP2_PostDialogueData.postDialogueData[index];
                Instance.SetCardText(1, text);
                break;
            case "NCP3":
                text = Instance.NCP3_PostDialogueData.postDialogueData[index];
                Instance.SetCardText(2, text);
                break;
            case "NCP4":
                text = Instance.NCP4_PostDialogueData.postDialogueData[index];
                Instance.SetCardText(3, text);
                break;
        }
    }


    public void ReturnMap()
    {
        SceneManager.LoadScene(3);
    }
}