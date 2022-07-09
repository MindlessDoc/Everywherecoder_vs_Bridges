using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationButtonController : MonoBehaviour
{

    [SerializeField] private Button _informationButton;
    [SerializeField]
    
    void Start()
    {
        _informationButton.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        
    }
}
