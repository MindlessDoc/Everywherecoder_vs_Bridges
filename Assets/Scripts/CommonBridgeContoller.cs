using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommonBridgeContoller : MonoBehaviour
{
    [SerializeField] private GameObject _commonController;

    [SerializeField] private Button[] _buttons;
    [SerializeField] private BridgeController[] _bridgeControllers;

    private FirstLevelScenario _scenario;

    private int curbridgeId;
    public void Activate(int bridgeId)
    {
        //TODO убрать
        if (_scenario == null)
        {
            _scenario = new FirstLevelScenario(_buttons, _bridgeControllers);
        }
        curbridgeId = bridgeId;
        _commonController.SetActive(true);
    }

    public void Deactivate()
    {
        _commonController.SetActive(false);
    }
}
