using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoNextController : MonoBehaviour
{
    [SerializeField] private Button nextButton;
    [SerializeField] private GameObject nextInfoMessage;
    [SerializeField] private GameObject curInfoMessage;
    
    void Start()
    {
        nextButton.onClick.AddListener(onClick);
    }

    void onClick()
    {
        nextInfoMessage.SetActive(true);
        curInfoMessage.SetActive(false);
    }
}
