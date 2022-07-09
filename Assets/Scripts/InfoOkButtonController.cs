using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoOkButtonController : MonoBehaviour
{
    [SerializeField] private Button OkButton;
    [SerializeField] private GameObject infoPanel;
    
    void Start()
    {
        OkButton.onClick.AddListener(OnClick);
    }
    
    void OnClick()
    {
        Destroy(infoPanel);
    }
}
