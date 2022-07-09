using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BridgeControllButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private BridgeContoller _bridge;
    
    void Start()
    {
        _button.onClick.AddListener(_bridge.UpdateState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
