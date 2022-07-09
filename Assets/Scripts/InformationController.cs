using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationController : MonoBehaviour
{
    [SerializeField] private GameObject _informationPanel;
    [SerializeField] private Button _infoButton;

    private GameObject curInfoPanel = null;
    
    void Start()
    {
        _infoButton.onClick.AddListener(OnClick);
    }
    
    void OnClick()
    {
        if (curInfoPanel == null)
        {
            curInfoPanel = Instantiate(_informationPanel, new Vector2(0, 0), Quaternion.identity);
        }
        else
        {
            Destroy(curInfoPanel);
        }
    }
}
