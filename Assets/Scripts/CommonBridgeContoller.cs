using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonBridgeContoller : MonoBehaviour
{
    [SerializeField] private GameObject _commonController;

    public void Activate()
    {
        _commonController.SetActive(true);
    }

    public void Deactivate()
    {
        _commonController.SetActive(false);
    }
}
