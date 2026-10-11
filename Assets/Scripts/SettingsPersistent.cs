using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPersistent : MonoBehaviour
{
    public static SettingsPersistent Instance { get; private set; }

    public List<string> card1Lines = new();
    public List<string> card2Lines = new();
    public List<string> card3Lines = new();
    public List<string> card4Lines = new();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
