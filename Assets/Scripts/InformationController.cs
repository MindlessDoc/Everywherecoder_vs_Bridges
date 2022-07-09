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
            Time.timeScale = 0;
            curInfoPanel = Instantiate(_informationPanel, new Vector2(0, 0), Quaternion.identity);
        }
        else
        {
            Time.timeScale = 1;
            Destroy(curInfoPanel);
        }
    }
}
