using System;
using UnityEngine;
using UnityEngine.UI;

public class FirstLevelScenario
{
    private Button[] _buttons;
    private Action[] scenarios;

    public FirstLevelScenario(Button[] buttons, BridgeController[] _bridgeControllers)
    {
        _buttons = buttons;

        scenarios = new Action[4];

        /*scenarios[3] = new Action(
        });*/
        
        _buttons[0].onClick.AddListener(() =>
        {
            if (!_bridgeControllers[1].isClosed())
            {
                _bridgeControllers[3].UpdateState();
            }
            else
            {
                _bridgeControllers[0].UpdateState();
            }
        });
        
        _buttons[1].onClick.AddListener(() =>
        {
            if (!_bridgeControllers[3].isClosed())
            {
                _bridgeControllers[3].UpdateState();
            }
            else
            {
                _bridgeControllers[2].UpdateState();
            }
        });
        
        _buttons[2].onClick.AddListener(() =>
        {
            if (!_bridgeControllers[0].isClosed())
            {
                _bridgeControllers[1].UpdateState();
            }
            else
            {
                _bridgeControllers[3].UpdateState();
            }
        });
        
        _buttons[3].onClick.AddListener(() =>
        {
            if (!_bridgeControllers[2].isClosed())
            {
                _bridgeControllers[3].UpdateState();
            }
            else
            {
                _bridgeControllers[1].UpdateState();
            }
        });
    }

    /*public void ActivateScenario(int number)
    {
        scenarios[number]();
    }*/
}