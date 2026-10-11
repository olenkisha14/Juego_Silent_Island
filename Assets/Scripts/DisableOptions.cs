using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using Yarn.Unity.Legacy;

public class DisableOptions : MonoBehaviour
{
    [SerializeField] OptionItem optionItem;
    [SerializeField] OptionsPresenter optionsPresenter;
    //OptionsListView optionsListView;
    // Start is called before the first frame update
    void Start()
    {
        optionsPresenter.showUnavailableOptions = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
