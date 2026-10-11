using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class DisableExitButton : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;
    [SerializeField] Button exitButton;
    void Start()
    {

    }

    void Update()
    {
        if (runner.IsDialogueRunning)
        {
            exitButton.gameObject.SetActive(false);
        }
        else
        {
            exitButton.gameObject.SetActive(true);
        }
    }
}