using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DayText : MonoBehaviour
{

    [SerializeField] TMP_Text DayTexto;
    // Start is called before the first frame update
    void Start()
    {
        DayTexto.SetText(MenuInicial.Day.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}