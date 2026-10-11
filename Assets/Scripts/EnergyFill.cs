using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyFill : MonoBehaviour
{
    [SerializeField] Image energyBar;
    [SerializeField] private float initialEnergy = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var energyRatio = MenuInicial.Energy / initialEnergy;
        energyBar.fillAmount = energyRatio;
        Debug.Log(Settings.textPersistence1);
    }
}
