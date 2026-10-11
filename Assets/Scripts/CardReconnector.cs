using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardReconnector : MonoBehaviour
{
    [SerializeField] private TMP_Text card1;
    [SerializeField] private TMP_Text card2;
    [SerializeField] private TMP_Text card3;
    [SerializeField] private TMP_Text card4;

    private void Start()
    {
        if (Settings.Instance != null)
        {
        //    Settings.Instance.ReassignCards(card1, card2, card3, card4);
        }
    }
}
